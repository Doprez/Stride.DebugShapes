using Stride.Core.Mathematics;
using Stride.Engine;
using Stride.Rendering.Compositing;

namespace DebugShapes.Code;
public class TestDebugRender : SyncScript
{

	private ImmediateDebugRenderSystem debugRender;

	public override void Start()
	{
		base.Start();

		debugRender = Services.GetService<ImmediateDebugRenderSystem>();
		debugRender.Visible = true;
	}

	public override void Update()
	{
		debugRender.DrawArrow(Vector3.Zero, Vector3.UnitX, color: Color.Red, depthTest: false);
	}
}
