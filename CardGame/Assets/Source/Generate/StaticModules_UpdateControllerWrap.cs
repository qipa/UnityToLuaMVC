﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class StaticModules_UpdateControllerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(StaticModules.UpdateController), typeof(System.Object));
		L.RegFunction("GetInstance", GetInstance);
		L.RegFunction("Show", Show);
		L.RegFunction("Hide", Hide);
		L.RegFunction("LoadServerFiles", LoadServerFiles);
		L.RegFunction("New", _CreateStaticModules_UpdateController);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateStaticModules_UpdateController(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				StaticModules.UpdateController obj = new StaticModules.UpdateController();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: StaticModules.UpdateController.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInstance(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			StaticModules.UpdateController o = StaticModules.UpdateController.GetInstance();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Show(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			StaticModules.UpdateController obj = (StaticModules.UpdateController)ToLua.CheckObject(L, 1, typeof(StaticModules.UpdateController));
			UnityEngine.GameObject o = obj.Show();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Hide(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			StaticModules.UpdateController obj = (StaticModules.UpdateController)ToLua.CheckObject(L, 1, typeof(StaticModules.UpdateController));
			obj.Hide();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadServerFiles(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			StaticModules.UpdateController obj = (StaticModules.UpdateController)ToLua.CheckObject(L, 1, typeof(StaticModules.UpdateController));
			System.Collections.IEnumerator o = obj.LoadServerFiles();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
