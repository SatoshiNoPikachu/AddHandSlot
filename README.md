# 增加手牌槽位（Add Hand Slot）- CSTI MOD



## 简介

增加手牌槽位（Add Hand Slot）是一个综合功能类Mod。

功能如下：

修改手牌槽位数量（依赖于ModLoader，需选用特质，或在配置文件中使用 “强制增加手牌槽位的数量” 功能）。

缩小以下槽位或栏的尺寸（需在配置文件中手动启用）：

- 环境槽位
- 基础槽位
- 手牌槽位
- 蓝图槽位
- 容器槽位
- 装备槽位（伤口槽位）
- 探索槽位（自动根据槽位数量启用）
- 状态栏

双行槽位（需在配置文件中手动启用）：

- 环境槽位
- 基础槽位
- 手牌槽位
- 容器槽位
- 装备槽位（伤口槽位）
- 探索槽位（自动根据槽位数量启用）

特殊功能（需在配置文件中手动启用）：

- 容器动态双行槽位
- 状态条延长

未开放功能：

- 修改探索槽位数量

修改玩家的负重上限（需在配置文件中手动启用）。



<u>有关配置文件的内容，详情请看配置说明。</u>

强烈建议使用 Bepinex 插件 ConfigurationManager 修改配置项！

手动修改配置文件视频教学：https://www.bilibili.com/video/BV12w411N75f/



游戏中新增了三种特质：增加手牌槽位；只有一个手牌槽位；只有两个手牌槽位。



当前版本：2.0.4

By.サトシの皮卡丘



## 安装说明

请将Mod压缩包解压于 BepInEx\plugins 文件夹下。

注意：部分功能需前置Mod：ModLoader v2.0.1+。



## 配置说明

配置文件：BepInEx\config\Pikachu.AddHandSlot.cfg

注意：该文件需要至少运行一次本Mod才会生成，修改后重启游戏生效！

另外，可以使用插件 Configuration Manager 修改配置（在游戏中按 F1 打开配置界面）。



### 增加手牌槽位的数量

类别：Config

键名：AddHandSlotNum

范围：-6-10000（默认为 6）

说明：值为负数时，实际效果为减少手牌槽位数量。



### 强制增加手牌槽位的数量

类别：Config

键名：ForceAddHandSlot

范围：true（启用），false（禁用，默认）

说明：启用后，将会修改下次打开存档的手牌槽位数量（根据配置项 AddSlotNum），生效后会立即自动禁用本项。



### 是否修改负重上限

类别：Config

键名：EnableModifyEncumbrance

范围：true（启用），false（禁用，默认）



### 增加负重上限的值

类别：Config

键名：AddEncumbranceNum

范围：-4000-1000000（默认为 6000）

说明：值为负数时，实际效果为减少负重上限。



### 双行环境槽位

类别：DoubleLine

键名：EnableLocation

范围：true（启用，默认），false（禁用）

说明：开启后将强制修改环境槽位的尺寸。



### 双行基础槽位

类别：DoubleLine

键名：EnableBase

范围：true（启用，默认），false（禁用）

说明：开启后将强制修改基础槽位的尺寸。



### 双行手牌槽位

类别：DoubleLine

键名：EnableHand

范围：true（启用），false（禁用，默认）

说明：开启后将强制修改手牌槽位的尺寸。



### 双行蓝图槽位

类别：DoubleLine

键名：EnableBlueprint

范围：true（启用），false（禁用，默认）

说明：体验版功能，待优化。开启后将强制修改蓝图槽位的尺寸。



### 双行容器槽位

类别：DoubleLine

键名：EnableInventory

范围：true（启用，默认），false（禁用）

说明：开启后将强制修改容器槽位的尺寸。



### 双行装备槽位

类别：DoubleLine

键名：EnableEquipment

范围：true（启用，默认），false（禁用）

说明：开启后将强制修改装备槽位的尺寸。



### 修改环境槽位的尺寸

类别：SlotScale

键名：EnableLocation

范围：true（启用，默认），false（禁用）



### 修改基础槽位的尺寸

类别：SlotScale

键名：EnableBase

范围：true（启用，默认），false（禁用）



### 修改手牌槽位的尺寸

类别：SlotScale

键名：EnableHand

范围：true（启用），false（禁用，默认）



### 修改蓝图槽位的尺寸

类别：SlotScale

键名：EnableBlueprint

范围：true（启用，默认），false（禁用）



### 修改容器槽位的尺寸

类别：SlotScale

键名：EnableInventory

范围：true（启用，默认），false（禁用）



### 修改装备槽位的尺寸

类别：SlotScale

键名：EnableEquipment

范围：true（启用，默认），false（禁用）



### 修改状态栏的尺寸

类别：StatScale

键名：EnableBar

范围：true（启用，默认），false（禁用）



### 容器动态双行槽位

类别：Special

键名：EnableInventoryDynamicDoubleLine

范围：true（启用，默认），false（禁用）

说明：需同时启用双行容器槽位生效，启用后仅当容器槽位数量大于8时才会按双行显示。



### 状态条延长

类别：Special

键名：EnableStatusBarElongate

范围：true（启用，默认），false（禁用）

说明：仅当启用功能 “修改状态栏的尺寸” 时生效，生效后状态条将延长以填满状态栏的空间。动态修改该配置项后需重新加载存档以完全生效/禁用。



## 更新日志

### Version 2.0.4

1. 新增 “探索栏” 槽位的增加功能，以及应对不同槽位数量时的缩小和双行。

   该功能目前仅为Mod作者提供，玩家暂时无法直接使用。

2. 修改了部分功能配置项的默认值，现在他们默认启用了。

3. 修复了部分情况下，状态栏会崩溃的问题。



### Version 2.0.3

1. 修复特质 “增加手牌槽位” 实际增加数量始终为6的问题。
2. 修复功能 “双行手牌槽位” 在游戏进行时开关会出现部分槽位尺寸错误的问题。



### Version 2.0.2

1. 修复增加手牌数量不正确的问题。
2. 修复加载存档后手牌中部分物品会丢在基础卡槽的问题。



### Version 2.0.1

1. 修复了负重条显示范围不正确的问题。
2. 修复了在游戏进行时修改负重上限不会及时更新负重状态的问题。



### Version 2.0.0 [重要更新]

本次更新对DLL插件进行了完全重构，增强了部分功能，修复了部分问题，提高了可拓展性。

1. 现在不再强依赖于ModLoader，不会再因未安装ModLoader而导致加载游戏存档时出错。

   注意：未安装ModLoader时，增加手牌槽位的相关功能都将失效且无法使用！

2. 现在完全支持通过 Bepinex 插件 ConfigurationManager 修改配置项时进行响应，这意味着使用该插件修改配置项后，无需重新加载游戏或存档。

3. 更改了配置项“增加手牌槽位的数量”、“强制增加手牌槽位的数量”、“增加负重上限的值” 的键名，旧键名已废弃，详情请见配置说明。

4. 新增功能 “双行蓝图槽位”（需在配置文件中启用），详情请看配置说明。

   注意：该功能目前为体验版，待优化。

5. 修复了启用功能 “状态条延长” 时，钉子图标位置不正确的问题。

6. 修复了功能 “双行容器槽位”、“容器动态双行槽位” 在部分情况下不正常工作的问题。



### Version 1.4.3

修复了未开启功能 “修改容器槽位的尺寸” 时其部分情况下依旧生效的问题。



### Version 1.4.2

1. 修复了未开启功能 “容器动态双行槽位” 时其依旧生效的问题。
2. 新增功能 “状态条延长”（需在配置文件中启用），详情请看配置说明。



### Version 1.4.1

现在支持将装备（伤口）槽位修改成两行了（需在配置文件中启用），详情请看配置说明。



### Version 1.4.0

1. 新增功能 “修改状态栏的尺寸”（需在配置文件中启用），详情请看配置说明。
2. 调整了双行手牌槽位模式下，手牌槽位的整体位置，使得他们看起来更居中。



### Version 1.3.5

1. 新增测试功能 “容器动态双行槽位”（需在配置文件中启用）。启用后仅当容器槽位数量大于8时才会按双行显示，详情请看配置说明。
2. 由于 “手牌槽位新逻辑” 功能存在严重影响体验的问题，因此已将该功能移除。



### Version 1.3.4

1. 新增测试功能 “手牌槽位新逻辑”（需在配置文件中启用），开启后手牌将优先按行排列。

   警告！！！该功能未经过充分测试，请谨慎使用。

2. 修复了被 Modloader 管理器禁用后 DLL 可能仍在工作的问题。



### Version 1.3.3

1. 现在支持将环境槽位修改成两行了（需在配置文件中启用）。
2. 现在支持修改装备槽位的尺寸了（需在配置文件中启用）。
3. 优化了引用。



### Version 1.3.2

修复了在部分情况下双行槽位功能失效的问题。



### Version 1.3.1

1. 现在支持将基础槽位修改成两行了（需在配置文件中启用）。
2. 修复了修改负重后负重状态各阶段触发范围不正确的问题。



### Version 1.3.0

1. 现在支持将容器槽位修改成两行了（需在配置文件中启用）。
2. 双行手牌槽位的配置项已重新分类和命名，需要重新启用，原配置项已废弃。
3. 新增了修改负重上限的功能（需在配置文件中启用）。
4. 修复卡槽数量为奇数时会出现的显示问题。



### Version 1.2.4

1. 现在拖拽卡牌缩小的功能兼容游戏 1.04 版本了。
2. 现在兼容使用 ConfigurationManager 在游戏中修改配置项 “增加手牌槽位的数量”。



### Version 1.2.3

现在拖拽卡牌时会根据以下规则缩小卡牌：

1. 若启用了双行手牌槽位的功能，则缩小为50%；
2. 否则若启用了修改槽位尺寸的功能，则缩小为70%；
3. 不满足以上情况则不进行缩小。



### Version 1.2.2

现在支持将手牌槽位修改成两行了（需在配置文件中启用）。

非常感谢 Zender 大佬的算法提供。



### Version 1.2.1

1. 现在支持修改蓝图槽位和容器槽位的尺寸了（需各自在配置文件中启用）。
2. 现在支持通过 ModLoader 管理器禁用本 Mod 了（该功能仅在 ModLoader v2.0.8+ 可用）。



### Version 1.2.0

1. 配置项 “增加手牌的数量” 现在支持减少手牌槽位了。
2. 现在支持其他Mod在游戏中动态修改手牌槽位数量。
3. 再次下调特质 “只有一个手牌槽位”、“只有两个手牌槽位” 的难度分数。
4. 上调了 特质 “增加手牌槽位” 的难度分数。
5. 修复了强制修改手牌槽位数量时，在部分情况下需重新加载存档生效的问题。



### Version 1.1.3

尝试修复了减少手牌槽位时，开局物品会消失的问题，现在会尝试把他们丢在基础卡槽（有问题请及时反馈）。



### Version 1.1.2

修复了加载存档时，手牌顺序被打乱以及部分物品会被丢在基础卡槽的问题。



### Version 1.1.1

1. 新增对 1.0.x 版本的兼容，现在你可以通过 ForceAddSlot 配置项强制修改手牌槽位的数量，详情请看配置说明。
2. 下调了特质 “只有一个手牌槽位”、“只有两个手牌槽位” 的难度分数。



### Version 1.1.0

1. 重构了配置项文件（建议更新时先删除旧的配置文件），并新增了两项配置。
2. 新增三项特质：增加手牌槽位；只有一个手牌槽位；只有两个手牌槽位。
3. 现在增加手牌槽位需要启用特质“增加手牌槽位”。
4. 现在支持修改环境槽位和基础槽位的尺寸了（仍需各自在配置文件中启用）。
5. 现在不再直接支持对旧存档修改手牌槽位数量（仅在选用“增加手牌槽位”特质后建立新存档生效）。



### Version 1.0.2

新增允许通过配置项启用修改手牌槽位尺寸的功能。



### Version 1.0.1

新增允许通过配置项修改需增加手牌槽位数量的功能。