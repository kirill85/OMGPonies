using System;
using System.Windows;
using System.Threading;
using System.Collections.ObjectModel;

// Toolkit namespace
using SimpleMvvmToolkit;

// Toolkit extension methods
using SimpleMvvmToolkit.ModelExtensions;

namespace OMGPonies.Views
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// Use the <strong>mvvmprop</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// </summary>
    public class WorkersViewModel : ViewModelBase<WorkersViewModel>
    {
        #region Initialization and Cleanup

        // Add a member for IWorkerServiceAgent
        private IWorkersServiceAgent serviceAgent;

        // Default ctor
        public WorkersViewModel() { }

        // Ctor that accepts IWorkerServiceAgent
        public WorkersViewModel(IWorkersServiceAgent serviceAgent)
        {
            this.serviceAgent = serviceAgent;
        }

        #endregion

        #region Notifications

        // TODO: Add events to notify the view or obtain data from the view
        public event EventHandler<NotificationEventArgs<Exception>> ErrorNotice;

        #endregion

        #region Properties

        private System.Data.DataTable workers;
        public System.Data.DataTable Workers
        {
            get
            {
                if (IsInDesignMode) return null;
                return null;
            }
            set
            {
                workers = value;
                NotifyPropertyChanged(m => m.Workers);
            }
        }

        #endregion

        #region Methods

        // TODO: Add methods that will be called by the view

        #endregion

        #region Completion Callbacks

        // TODO: Optionally add callback methods for async calls to the service agent
        
        #endregion

        #region Helpers

        // Helper method to notify View of an error
        private void NotifyError(string message, Exception error)
        {
            // Notify view of an error
            Notify(ErrorNotice, new NotificationEventArgs<Exception>(message, error));
        }

        #endregion
    }
}