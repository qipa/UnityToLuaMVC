local GlobalEventController={};
local this=GlobalEventController;

function this.Init()
    print("GlobalEventController.Init()");
    GlobalVar.Event.AddListener(GlobalVar.Const.EVENT_STARTGAME,this.EVENT_STARTGAME);
    GlobalVar.Event.AddListener(GlobalVar.Const.EVENT_UPDATEGAME,this.EVENT_UPDATEGAME);
end

function this.EVENT_STARTGAME()
    GlobalVar.Event.RemoveListener(GlobalVar.Const.EVENT_STARTGAME);
    GlobalVar.GameManage.Start();
    --GlobalVar.ControllerManage.GetUpdateController().Show();
end

function this.EVENT_UPDATEGAME()
    GlobalVar.Event.RemoveListener(GlobalVar.Const.EVENT_UPDATEGAME);
    GlobalVar.ControllerManage.GetUpdateController().Show();
end

this.Init();
return this;