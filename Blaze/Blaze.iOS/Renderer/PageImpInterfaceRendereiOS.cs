using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using SlideOverKit.iOS;
using CoreGraphics;
using Blaze;
[assembly: ExportRenderer(typeof(SlideUpMenuPage), typeof(Blaze.iOS.Renderer.PageImpInterfaceRendereiOS))]
namespace Blaze.iOS.Renderer
{
    public class PageImpInterfaceRendereiOS : PageRenderer, ISlideOverKitPageRendereriOS
    {
        public Action<bool> ViewDidAppearEvent { get; set; }

        public Action<VisualElementChangedEventArgs> OnElementChangedEvent { get; set; }

        public Action ViewDidLayoutSubviewsEvent { get; set; }

        public Action<bool> ViewDidDisappearEvent { get; set; }

        public Action<CGSize, IUIViewControllerTransitionCoordinator> ViewWillTransitionToSizeEvent { get; set; }

        public PageImpInterfaceRendereiOS()
        {
            new SlideOverKitiOSHandler().Init(this);
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            OnElementChangedEvent?.Invoke(e);
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            ViewDidLayoutSubviewsEvent?.Invoke();

        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            ViewDidAppearEvent?.Invoke(animated);

        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            ViewDidDisappearEvent?.Invoke(animated);
        }

        public override void ViewWillTransitionToSize(CGSize toSize, IUIViewControllerTransitionCoordinator coordinator)
        {
            base.ViewWillTransitionToSize(toSize, coordinator);
            ViewWillTransitionToSizeEvent?.Invoke(toSize, coordinator);
        }
    }
}