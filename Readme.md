# BetterAnimation

BetterAnimation 是一个用于将 Unity 的 AnimationClip 转换为 DOTween 代码的插件，解决了 Animation 和 Animator 的许多缺点。它可以帮助开发者在 Unity 中更轻松地创建和管理UI动画。

## 优势

相较于传统的 Unity Animation 和 Animator，BetterAnimation 提供了以下优势：

1. 避免在高刷屏下因帧率波动导致丢帧的问题。
2. 提供对缓动函数变量的高自由度控制。
3. 允许在运行时修改 Keyframe，实现更高自由度的动画效果。
4. 更高效，避免了在许多 2D 项目中不必要的计算开销。
5. 支持在单个动画中插入事件，避免通用动画带来的问题。
6. 可以在动画中插入部分代码，如暂停动画并等待用户输入。
7. 支持反转动画播放，同时避免错误的事件回调。
8. 支持链式编程。
9. 快速切换状态并保留 GameObject 当前位置，提供更高的自由度。
10. 支持多个动画同时播放。
11. 提供更强大的事件触发机制，支持获取上下文数据。
12. 支持协程、async 和 await，更友好地支持异步编程。
13. 对代码调试更友好，便于查看相关数据。
14. 可控的生命周期以及执行周期

## Roadmap
1. 支持 DOTS 代码，适用于高性能、高优化的环境。
2. 支持 Generic 动画
3. 支持Transition

## 使用方法

1. 将 `BetterAnimation` 脚本添加到您希望使用的游戏对象上。
2. 打开ProjectStteing找到Better Animation Config 修改 AOT代码路径和动画序列化文件路径
3. 在 Unity 编辑器中，将所需的 AnimationClip 添加到 `BetterAnimation` 组件中的 AnimationClip 列表中。
4. 在脚本中调用 `DoJob(animationName)` 方法，该方法将返回一个 `AnimationBuilder` 对象，用于配置和播放动画。

## 示例

以下是 BetterAnimation 的一个基本示例：

```csharp
public class BetterAnimationExample : MonoBehaviour
{
    public BetterAnimation betterAnimation;

    private void Start()
    {
        var animationBuilder = betterAnimation.DoJob("ExampleAnimation");
        animationBuilder.OnComplete(() => Debug.Log("Animation completed"))
                        .SetLoops(2)
                        .Play();
    }
}
```

## 注意

该插件对 **Unity 的 Animation Window** 进行了钩子操作。您也可以选择不使用钩子，但这可能会导致您失去以下特性：

1. **无法直接编辑帧事件**：使用钩子功能允许您直接编辑帧事件，否则这将无法实现。
2. **组件兼容性**：在使用 BetterAnimation 的组件时，仍然需要挂载 Animation/Animator 组件，否则 Animation Window 无法检测到 Animation Clip。
3. **手动操作 Animation Clip**：在创建 Animation Clip 后，您需要手动将其拖动到 BetterAnimation 组件中。
