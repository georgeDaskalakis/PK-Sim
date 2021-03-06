﻿using OSPSuite.UI.Extensions;
using DevExpress.XtraLayout;
using DevExpress.XtraTab;
using PKSim.Presentation.Views;
using OSPSuite.Presentation.Views;

namespace PKSim.UI.Views.Core
{
   public partial class TabbedLayoutView : BaseContainerUserControl, ITabbedLayoutView
   {
      public TabbedLayoutView()
      {
         InitializeComponent();
         InitializeResources();
      }

      public void AddView(IView view)
      {
         var layoutControl = new LayoutControl();
         var xtraTabPage = new XtraTabPage();
         xtraTabPage.FillWith(layoutControl);
         xtraTabControl.TabPages.Add(xtraTabPage);
         xtraTabPage.Text = view.Caption;
         AddViewToGroup(layoutControl.Root, view);
         
         AddEmptyPlaceHolder(layoutControl);
      }

      public void FinishedAddingViews()
      {
      }

      public override void InitializeResources()
      {
         base.InitializeResources();
         xtraTabControl.HeaderLocation = TabHeaderLocation.Right;
         xtraTabControl.HeaderOrientation=TabOrientation.Horizontal;
      }
   }
}