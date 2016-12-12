using System;
using AK.Xamarin.Controls;
using AK.Xamarin.Plugins.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CardView), typeof(CardViewRenderer))]

namespace AK.Xamarin.Plugins.iOS
{
	public class CardViewRenderer : FrameRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
		{
			base.OnElementChanged(e);

			if (NativeView != null)
			{
				if (Element?.HasShadow ?? false)
				{
					AddShadow();
				}
			}
		}

		void AddShadow()
		{
			var layer = NativeView.Layer;

			layer.CornerRadius = 2f;
			layer.ShadowRadius = 1.4f;
			layer.ShadowOffset = new CoreGraphics.CGSize(0, 0.5);
			layer.ShadowColor = UIKit.UIColor.Black.CGColor;
			layer.ShadowOpacity = 0.36f;
		}
	}
}
