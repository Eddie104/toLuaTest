require("libra.init")

function test()
    LogUtil.Info('this is info');
    LogUtil.Debug('this is debug');
    LogUtil.Error('this is error');

    LogUtil.Info(Helper.DecodeBase64('eJwz1DEkFaqRrGNUz6ieUT1DQQ8AkMG8Sw=='));
end

--主入口函数。从这里开始lua逻辑
function Main()
    -- 安卓平台如果使用luajit的话，记得在lua最开始执行的地方请开启 jit.off()，性能会提升N倍。
    -- 记得安卓平台上在加上jit.opt.start(3)，相当于c++程序-O3，可选范围0-3，性能还会提升。Luajit作者建议-O2

	print("logic start")

    -- local bundle = AssetBundle.LoadFromFile(Application.dataPath .. '/AssetBundles/furni')
    -- local prefab = bundle:LoadAsset('floor_001')
    -- local newBox = GameObject.Instantiate(prefab)
    -- newBox.transform.position = Vector3(0, 0, 0)

    -- prefab = bundle:LoadAsset('furni_001')
    -- newBox = GameObject.Instantiate(prefab)
    -- newBox.transform.position = Vector3(0, 0, 0)

    -- test()


    -- UpdateBeat:Add(Update, self)


    -- local role = GameObject.Find('Body')
    -- role.transform.position = Vector3(1, 0, 0)
    local body = GameObject.FindGameObjectWithTag('Role_Body')
    local s = body.transform:GetComponent(typeof(SpriteRenderer))
    print(s)
--     SpriteRenderer sr = obj.transform.GetComponent<SpriteRenderer>();
--    Sprite sprite = Resources.Load("Textrues/XXX", typeof(Sprite)) as Sprite;
--    sr.sprite = sprite;
end

--场景切换通知
function OnLevelWasLoaded(level)
	collectgarbage("collect")
	Time.timeSinceLevelLoad = 0
end

function OnApplicationQuit()
end

function Update()
    LogUtil.Debug('aaa')
end