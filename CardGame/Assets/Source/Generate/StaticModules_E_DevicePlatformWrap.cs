﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class StaticModules_E_DevicePlatformWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(StaticModules.E_DevicePlatform));
		L.RegVar("StandaloneWindows64", get_StandaloneWindows64, null);
		L.RegVar("Android", get_Android, null);
		L.RegVar("iOS", get_iOS, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_StandaloneWindows64(IntPtr L)
	{
		ToLua.Push(L, StaticModules.E_DevicePlatform.StandaloneWindows64);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Android(IntPtr L)
	{
		ToLua.Push(L, StaticModules.E_DevicePlatform.Android);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_iOS(IntPtr L)
	{
		ToLua.Push(L, StaticModules.E_DevicePlatform.iOS);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		StaticModules.E_DevicePlatform o = (StaticModules.E_DevicePlatform)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

