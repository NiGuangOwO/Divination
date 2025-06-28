using Dalamud.Divination.Common.Api.Localize;

namespace Divination.AetheryteLinkInChat;

public static class Localization
{
    public static readonly LocalizedString TeleportingMessage = new()
    {
        En = "Teleporting to \"{0}\"...",
        Ja = "「{0}」にテレポしています...",
        Zh_CN = "正在传送至「{0}」...",
    };

    public static readonly LocalizedString TeleportingQuestMessage = new()
    {
        En = "Teleport to \"{0}\"",
        Ja = "「{0}」にテレポ",
        Zh_CN = "传送至「{0}」",
    };

    public static readonly LocalizedString QueueTeleportMessage = new()
    {
        En = "Currently unable to execute teleport. Teleport to \"{0}\" has been added to the queue.",
        Ja = "現在テレポを実行できません。「{0}」へのテレポをキューに追加しました。",
        Zh_CN = "当前无法执行传送。传送至「{0}」请求已添加到队列。",
    };

    public static readonly LocalizedString QueuedTeleportingMessage = new()
    {
        En = "Teleporting to \"{0}\" (queued) ...",
        Ja = "キューに追加された「{0}」にテレポしています...",
        Zh_CN = "正在传送至「{0}」（已排队）...",
    };

    public static readonly LocalizedString QueuedTeleportingQuestMessage = new()
    {
        En = "Teleport to \"{0}\" (queued)",
        Ja = "キューに追加された「{0}」にテレポ",
        Zh_CN = "传送至「{0}」（已排队）",
    };

    public static readonly LocalizedString ConfigWindowTitle = new()
    {
        En = "{0} Config",
        Ja = "{0} 設定",
        Zh_CN = "{0} 设置",
    };

    public static readonly LocalizedString AllowTeleportQueueing = new()
    {
        En = "Allow Teleport Queueing",
        Ja = "テレポを予約可能にする",
        Zh_CN = "允许传送排队",
    };

    public static readonly LocalizedString QueueTeleportDelay = new()
    {
        En = "Queued Teleport Delay (ms)",
        Ja = "予約したテレポを実行するまでの遅延 (ms)",
        Zh_CN = "排队传送延迟 (ms)",
    };

    public static readonly LocalizedString QueuedTeleportDescription = new()
    {
        En =
            "It can queue a teleportation when it is not possible to execute a teleportation, e.g. you are in combat.\nAfter teleporting becomes possible, the teleportation is executed after the delay set here.\nThis is necessary to prove that you are not cheating!",
        Ja = "戦闘中などでテレポが実行できないときはテレポをキューに追加します。\nテレポが可能になったあと、ここで設定された遅延を挟んでからテレポを実行します。\nこれはあなたが不正行為を行っていないと証明するために必要です！",
        Zh_CN = "当无法执行传送时，例如您正在战斗中，可以将传送请求添加到队列。\n在可以进行传送时，将在此处设置的延迟后执行传送。\n这是为了证明您没有作弊！",
    };

    public static readonly LocalizedString ConsiderTeleportsToOtherWorlds = new()
    {
        En = "Consider Teleportation to Other Worlds in Route Calculation",
        Ja = "他ワールドへのテレポを経路計算に考慮する",
        Zh_CN = "在路径计算中考虑到跨服的传送",
    };

    public static readonly LocalizedString ConsiderTeleportsToOtherWorldsDescription = new()
    {
        En =
            "When enabled, the Grand Company Aetheryte will be prepended to the best path\nif a destination world is different from the player's current world.",
        Ja = "有効にすると、目的地のワールドがプレイヤーの現在のワールドと異なる場合に、\n三国エーテライトを最短経路の先頭に付加します。",
        Zh_CN = "启用后，如果目的地的服务器与玩家当前的服务器不同，则将三大主城的以太之光添加到最佳路径的开头。",
    };

    public static readonly LocalizedString ConsiderTeleportsToOtherWorldsDisclaimer = new()
    {
        En = "This function simply detects the world name from the chat message.\nAs such, it may cause malfunctions.",
        Ja = "この機能は、単にワールド名をチャットメッセージから検出しているだけです。\nそのため、誤作動を起こす場合もあります。",
        Zh_CN = "此功能仅从聊天消息中检测世界名称。\n因此，可能会导致故障。",
    };

    public static readonly LocalizedString PreferredGrandCompanyAetheryte = new()
    {
        En = "Preferred Grand Company Aetheryte",
        Ja = "優先する三国エーテライト",
        Zh_CN = "优先使用的三大主城以太之光",
    };

    public static readonly LocalizedString PreferredGrandCompanyAetheryteDescription = new()
    {
        En = "You can select the preferred Grand Company Aetheryte\nto use for teleporting to other worlds, for example.",
        Ja = "別ワールドにテレポするときなどに使用する、\n優先する三国エーテライトを選択できます。",
        Zh_CN = "您可以选择用于传送到其他服务器的首选三大主城以太之光。",
    };

    public static readonly LocalizedString SaveConfigButton = new()
    {
        En = "Save & Close",
        Ja = "保存して閉じる",
        Zh_CN = "保存并关闭",
    };

    public static readonly LocalizedString TeleportGcHelpMessage = new()
    {
        En = "Teleports you to Grand Company Aetheryte. Useful for teleporting to other worlds. The aetheryte can be changed from plugin config.",
        Ja = "三国のエーテライトにテレポします。ワールド間テレポに便利です。優先する三国エーテライトは設定から変更できます。",
        Zh_CN = "传送至三大主城的以太之光。用于传送到其他服务器。可以从插件设置中更改首选的三大主城以太之光。",
    };

    public static readonly LocalizedString EnableLifestreamIntegration = new()
    {
        En = "Enable Lifestream Integration",
        Ja = "Lifestream との連携機能を有効にする",
        Zh_CN = "启用 Lifestream 联动",
    };

    public static readonly LocalizedString EnableLifestreamIntegrationDescription = new()
    {
        En = "If enabled, teleporting to destinations will be automated, including world traveling and aethernet transfers.\nLifestream plugin required!",
        Ja = "有効にすると、ワールド間テレポや都市内エーテライトの移動を含め、目的地へのテレポが自動化されます。\nこの機能を使用するには、Lifestream プラグインが必要です！",
        Zh_CN = "启用后，将自动传送到目的地，包括跨服务器传送和城内以太水晶传送。\n需要 Lifestream 插件！",
    };

    public static readonly LocalizedString LifestreamUnavailable = new()
    {
        En = "Lifestream plugin is not available. Please install it.",
        Ja = "Lifestream がインストールされていません。",
        Zh_CN = "Lifestream 插件不可用。请安装。",
    };

    public static readonly LocalizedString DisplayLineBreak = new()
    {
        En = "Line break before teleport links",
        Ja = "テレポリンクの前に改行を入れる",
        Zh_CN = "在传送链接之前插入换行",
    };

    public static readonly LocalizedString DisplayLinkAtEnd = new()
    {
        En = "Display teleport link at the end of the message",
        Ja = "メッセージの最後にテレポート リンクを表示する",
        Zh_CN = "在消息末尾显示传送链接",
    };

    public static readonly LocalizedString EnableChatNotificationOnTeleport = new()
    {
        En = "Enable Chat Notification on Teleport",
        Ja = "テレポ実行時にチャット通知を有効にする",
        Zh_CN = "在传送时启用聊天通知",
    };

    public static readonly LocalizedString EnableQuestNotificationOnTeleport = new()
    {
        En = "Enable Toast Notification on Teleport",
        Ja = "テレポ実行時にトースト通知を有効にする",
        Zh_CN = "在传送时启用弹出通知",
    };

    public static readonly LocalizedString IgnoredAetherytes = new()
    {
        En = "You can set a specific aetherite not to be used in route calculations.",
        Ja = "特定のエーテライトを経路計算で使用しないように設定できます。",
        Zh_CN = "您可以设置特定的以太之光不参与路径计算。",
    };
}
