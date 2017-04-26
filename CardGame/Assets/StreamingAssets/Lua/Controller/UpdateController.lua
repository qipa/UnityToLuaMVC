local UpdateController={};
local this=UpdateController;

local resURL = "http://127.0.0.1:81/";
local View;

function this.Init()
    print("UpdateController.Init()");
end

function this.Show()
    print("UpdateController.Show()");
    if View==nil then
        View = UnityEngine.GameObject.Instantiate(GlobalVar.ResourceManage.GetInstance():Load("test_prefab"));
        local script=require("View/UpdateControllerView");
        LuaBehaviour.AddLuaBehaviourLiftCycleFunction(StaticModules.E_MonoBehaviourLiftCycle.Awake,script.Awake);
        LuaBehaviour.AddLuaBehaviour(View);
    end
end
    
this.Init();
return this;


