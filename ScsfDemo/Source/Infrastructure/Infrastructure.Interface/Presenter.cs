﻿//----------------------------------------------------------------------------------------
// patterns & practices - Smart Client Software Factory - Guidance Package
//
// This file was generated by this guidance package as part of the solution template
//
// This class contains code that otherwise would be repeated in every presenter when using the M-V-P pattern. 
// It includes a reference to a generic view and a reference to the WorkItem it belongs. 
// It also provides virtual methods to work with the controlled view
// 
//  
//
//
// Latest version of this Guidance Package: http://go.microsoft.com/fwlink/?LinkId=62182
//----------------------------------------------------------------------------------------

using Microsoft.Practices.CompositeUI;
using System;
using Microsoft.Practices.CompositeUI.SmartParts;

namespace ScsfDemo.Infrastructure.Interface
{
	public abstract class Presenter<TView> : IDisposable
	{
		private TView _view;
		private WorkItem _workItem;
		private bool disposed = false;

		public TView View
		{
			get { return _view; }
			set { _view = value; OnViewSet(); }
		}

		[ServiceDependency]
		public WorkItem WorkItem
		{
			get { return _workItem; }
			set { _workItem = value; }
		}

		protected virtual void CloseView()
		{
			Services.IWorkspaceLocatorService locator = WorkItem.Services.Get<Services.IWorkspaceLocatorService>();
			IWorkspace wks = locator.FindContainingWorkspace(WorkItem, View);
			if (wks != null)
				wks.Close(View);
		}

		public virtual void OnViewReady() { }
		protected virtual void OnViewSet() { }
		public virtual void OnCloseView() { }

		/// <summary>
		/// See <see cref="System.IDisposable.Dispose"/> for more information.
		/// </summary>
		public void Dispose()
		{
			if (!disposed) {
				Dispose(true);
				GC.SuppressFinalize(this);
			}
		}

		/// <summary>
		/// Called when the object is being disposed or finalized.
		/// </summary>
		/// <param name="disposing">True when the object is being disposed (and therefore can
		/// access managed members); false when the object is being finalized without first
		/// having been disposed (and therefore can only touch unmanaged members).</param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing) {
				if (_workItem != null) {
					if (this.View != null) {
						OnCloseView();
						_workItem.Items.Remove(this.View);
					}

					_workItem.Items.Remove(this);
				}
			}

			disposed = true;
		}
	}
}

