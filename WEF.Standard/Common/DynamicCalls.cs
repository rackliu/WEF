﻿/*****************************************************************************************************
 * 本代码版权归Wenli所有，All Rights Reserved (C) 2015-2022
 *****************************************************************************************************
 * 所属域：WENLI-PC
 * 登录用户：yswenli
 * CLR版本：4.0.30319.17929
 * 唯一标识：fc2b3c60-82bd-4265-bf8c-051e512a1035
 * 机器名称：WENLI-PC
 * 联系人邮箱：wenguoli_520@qq.com
 *****************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace WEF.Common
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public delegate object FastInvokeHandler(object target, object[] parameters);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public delegate object FastCreateInstanceHandler();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <returns></returns>
    public delegate object FastPropertyGetHandler(object target);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="parameter"></param>
    public delegate void FastPropertySetHandler(object target, object parameter);

    /// <summary>
    /// 动态调用
    /// </summary>
    public static class DynamicCalls
    {
        /// <summary>
        /// 用于存放GetMethodInvoker的Dictionary
        /// </summary>
        private static Dictionary<MethodInfo, FastInvokeHandler> dictInvoker = new Dictionary<MethodInfo, FastInvokeHandler>();

        /// <summary>
        /// GetMethodInvoker
        /// </summary>
        /// <param name="methodInfo"></param>
        /// <returns></returns>
        public static FastInvokeHandler GetMethodInvoker(MethodInfo methodInfo)
        {
            lock (dictInvoker)
            {
                if (dictInvoker.ContainsKey(methodInfo))
                    return (FastInvokeHandler)dictInvoker[methodInfo];

                DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[] { typeof(object), typeof(object[]) }, methodInfo.DeclaringType.Module);

                ILGenerator ilGenerator = dynamicMethod.GetILGenerator();

                ParameterInfo[] parameters = methodInfo.GetParameters();

                Type[] paramTypes = new Type[parameters.Length];

                for (int i = 0; i < paramTypes.Length; i++)
                {
                    if (parameters[i].ParameterType.IsByRef)
                        paramTypes[i] = parameters[i].ParameterType.GetElementType();
                    else
                        paramTypes[i] = parameters[i].ParameterType;
                }

                LocalBuilder[] locals = new LocalBuilder[paramTypes.Length];

                for (int i = 0; i < paramTypes.Length; i++)
                {
                    locals[i] = ilGenerator.DeclareLocal(paramTypes[i], true);
                }

                for (int i = 0; i < paramTypes.Length; i++)
                {
                    ilGenerator.Emit(OpCodes.Ldarg_1);
                    EmitFastInt(ilGenerator, i);
                    ilGenerator.Emit(OpCodes.Ldelem_Ref);
                    EmitCastToReference(ilGenerator, paramTypes[i]);
                    ilGenerator.Emit(OpCodes.Stloc, locals[i]);
                }

                if (!methodInfo.IsStatic)
                {
                    ilGenerator.Emit(OpCodes.Ldarg_0);
                }

                for (int i = 0; i < paramTypes.Length; i++)
                {
                    if (parameters[i].ParameterType.IsByRef)
                        ilGenerator.Emit(OpCodes.Ldloca_S, locals[i]);
                    else
                        ilGenerator.Emit(OpCodes.Ldloc, locals[i]);
                }
                ilGenerator.EmitCall(!methodInfo.IsStatic ? OpCodes.Callvirt : OpCodes.Call, methodInfo, null);

                if (methodInfo.ReturnType == typeof(void))
                {
                    ilGenerator.Emit(OpCodes.Ldnull);
                }
                else
                {
                    EmitBoxIfNeeded(ilGenerator, methodInfo.ReturnType);
                }
                for (int i = 0; i < paramTypes.Length; i++)
                {
                    if (parameters[i].ParameterType.IsByRef)
                    {
                        ilGenerator.Emit(OpCodes.Ldarg_1);
                        EmitFastInt(ilGenerator, i);
                        ilGenerator.Emit(OpCodes.Ldloc, locals[i]);
                        if (locals[i].LocalType.IsValueType)
                            ilGenerator.Emit(OpCodes.Box, locals[i].LocalType);
                        ilGenerator.Emit(OpCodes.Stelem_Ref);
                    }
                }
                ilGenerator.Emit(OpCodes.Ret);
                FastInvokeHandler invoker = (FastInvokeHandler)dynamicMethod.CreateDelegate(typeof(FastInvokeHandler));
                dictInvoker.Add(methodInfo, invoker);
                return invoker;
            }
        }

        /// <summary>
        /// 用于存放GetInstanceCreator的Dictionary
        /// </summary>
        private static Dictionary<Type, FastCreateInstanceHandler> dictCreator = new Dictionary<Type, FastCreateInstanceHandler>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static FastCreateInstanceHandler GetInstanceCreator(Type type)
        {
            lock (dictCreator)
            {
                if (dictCreator.ContainsKey(type))
                    return (FastCreateInstanceHandler)dictCreator[type];
                DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, type, new Type[0], typeof(DynamicCalls).Module);

                ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
                ilGenerator.Emit(OpCodes.Newobj, type.GetConstructor(Type.EmptyTypes));

                ilGenerator.Emit(OpCodes.Ret);

                FastCreateInstanceHandler creator = (FastCreateInstanceHandler)dynamicMethod.CreateDelegate(typeof(FastCreateInstanceHandler));

                dictCreator.Add(type, creator);

                return creator;
            }
        }

        /// <summary>
        /// 用于存放GetPropertyGetter的Dictionary
        /// </summary>
        private static Dictionary<PropertyInfo, FastPropertyGetHandler> dictGetter = new Dictionary<PropertyInfo, FastPropertyGetHandler>();

        /// <summary>
        /// GetPropertyGetter
        /// </summary>
        /// <param name="propInfo"></param>
        /// <returns></returns>
        public static FastPropertyGetHandler GetPropertyGetter(PropertyInfo propInfo)
        {
            lock (dictGetter)
            {
                if (dictGetter.ContainsKey(propInfo))
                    return (FastPropertyGetHandler)dictGetter[propInfo];

                DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[] { typeof(object) }, propInfo.DeclaringType.Module);

                ILGenerator ilGenerator = dynamicMethod.GetILGenerator();

                ilGenerator.Emit(OpCodes.Ldarg_0);

                ilGenerator.EmitCall(OpCodes.Callvirt, propInfo.GetGetMethod(), null);

                EmitBoxIfNeeded(ilGenerator, propInfo.PropertyType);

                ilGenerator.Emit(OpCodes.Ret);

                FastPropertyGetHandler getter = (FastPropertyGetHandler)dynamicMethod.CreateDelegate(typeof(FastPropertyGetHandler));

                dictGetter.Add(propInfo, getter);

                return getter;
            }
        }

        /// <summary>
        /// 用于存放SetPropertySetter的Dictionary
        /// </summary>
        private static Dictionary<PropertyInfo, FastPropertySetHandler> dictSetter = new Dictionary<PropertyInfo, FastPropertySetHandler>();

        /// <summary>
        /// GetPropertySetter
        /// </summary>
        /// <param name="propInfo"></param>
        /// <returns></returns>
        public static FastPropertySetHandler GetPropertySetter(PropertyInfo propInfo)
        {
            lock (dictSetter)
            {
                if (dictSetter.ContainsKey(propInfo))
                    return (FastPropertySetHandler)dictSetter[propInfo];

                DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, null, new Type[] { typeof(object), typeof(object) }, propInfo.DeclaringType.Module);

                ILGenerator ilGenerator = dynamicMethod.GetILGenerator();

                ilGenerator.Emit(OpCodes.Ldarg_0);

                ilGenerator.Emit(OpCodes.Ldarg_1);

                EmitCastToReference(ilGenerator, propInfo.PropertyType);

                ilGenerator.EmitCall(OpCodes.Callvirt, propInfo.GetSetMethod(), null);

                ilGenerator.Emit(OpCodes.Ret);

                FastPropertySetHandler setter = (FastPropertySetHandler)dynamicMethod.CreateDelegate(typeof(FastPropertySetHandler));

                dictSetter.Add(propInfo, setter);

                return setter;
            }
        }

        /// <summary>
        /// EmitCastToReference
        /// </summary>
        /// <param name="ilGenerator"></param>
        /// <param name="type"></param>
        private static void EmitCastToReference(ILGenerator ilGenerator, System.Type type)
        {
            if (type.IsValueType)
            {
                ilGenerator.Emit(OpCodes.Unbox_Any, type);
            }
            else
            {
                ilGenerator.Emit(OpCodes.Castclass, type);
            }
        }

        /// <summary>
        /// EmitBoxIfNeeded
        /// </summary>
        /// <param name="ilGenerator"></param>
        /// <param name="type"></param>
        private static void EmitBoxIfNeeded(ILGenerator ilGenerator, System.Type type)
        {
            if (type.IsValueType)
            {
                ilGenerator.Emit(OpCodes.Box, type);
            }
        }

        /// <summary>
        /// EmitFastInt
        /// </summary>
        /// <param name="ilGenerator"></param>
        /// <param name="value"></param>
        private static void EmitFastInt(ILGenerator ilGenerator, int value)
        {
            switch (value)
            {
                case -1:
                    ilGenerator.Emit(OpCodes.Ldc_I4_M1);
                    return;
                case 0:
                    ilGenerator.Emit(OpCodes.Ldc_I4_0);
                    return;
                case 1:
                    ilGenerator.Emit(OpCodes.Ldc_I4_1);
                    return;
                case 2:
                    ilGenerator.Emit(OpCodes.Ldc_I4_2);
                    return;
                case 3:
                    ilGenerator.Emit(OpCodes.Ldc_I4_3);
                    return;
                case 4:
                    ilGenerator.Emit(OpCodes.Ldc_I4_4);
                    return;
                case 5:
                    ilGenerator.Emit(OpCodes.Ldc_I4_5);
                    return;
                case 6:
                    ilGenerator.Emit(OpCodes.Ldc_I4_6);
                    return;
                case 7:
                    ilGenerator.Emit(OpCodes.Ldc_I4_7);
                    return;
                case 8:
                    ilGenerator.Emit(OpCodes.Ldc_I4_8);
                    return;
            }
            if (value > -129 && value < 128)
            {
                ilGenerator.Emit(OpCodes.Ldc_I4_S, (SByte)value);
            }
            else
            {
                ilGenerator.Emit(OpCodes.Ldc_I4, value);
            }
        }
    }
}

