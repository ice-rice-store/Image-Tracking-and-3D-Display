11.4 第一次上传
Unity3D Vuforia《AR文物》（第一版）项目源文件

11.18 第二次上传
Unity3D Vuforia—_AR文物》
优化：
1.调整模型旋转速度
修改前：
public class Rotate : MonoBehaviour
{
    // 速度
    float xSpeed = 200f;//发现旋转速度过快不好控制
    float ySpeed = 2000f;
    ......
}

修改后：
public class Rotate : MonoBehaviour
{
    // 速度
    float xSpeed = 20f; // 修改为0.1倍
    float ySpeed = 200f;
}

2.添加滚动旋转功能（绕y轴旋转）
原本模型只有绕z轴旋转和缩放的功能，现在添加绕y轴旋转的功能，方便用户全方位观察
添加代码：
{
    // 处理双指触摸，判断两个手指是否朝同一个方向滑动
    Vector2 touch0Delta = Input.GetTouch(0).deltaPosition;
    Vector2 touch1Delta = Input.GetTouch(1).deltaPosition;

    // 判断两个手指的滑动方向是否一致
    if (Vector2.Dot(touch0Delta.normalized, touch1Delta.normalized) > 0)
    {
        // 计算滑动量并进行旋转，绕X轴旋转
        float deltaY = (touch0Delta.y + touch1Delta.y) * 0.1f; // 使用0.1倍的速度
        transform.Rotate(Vector3.right * deltaY);
    }
}

