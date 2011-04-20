using System;
using System.Windows;
using System.Windows.Input;
using System.Threading;
using System.Collections.ObjectModel;

// Toolkit namespace
using SimpleMvvmToolkit;

// Toolkit extension methods
using SimpleMvvmToolkit.ModelExtensions;

namespace OMGPonies
{
    /// <summary>
    /// This class extends ViewModelDetailBase which implements IEditableDataObject.
    /// <para>
    /// Specify type being edited <strong>DetailType</strong> as the second type argument
    /// and as a parameter to the seccond ctor.
    /// </para>
    /// <para>
    /// Use the <strong>mvvmprop</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// </summary>
    public class WorkerViewModel : ViewModelDetailBase<WorkerViewModel, Worker>
    {
        #region Initialization and Cleanup

        // Add a member for IWorkerServiceAgent
        private IWorkerServiceAgent serviceAgent;

        // Default ctor
        public WorkerViewModel() { }

        // Ctor that accepts IWorkerServiceAgent
        public WorkerViewModel(IWorkerServiceAgent serviceAgent)
        {
            this.serviceAgent = serviceAgent;
        }

        #endregion

        #region Notifications

        // TODO: Add events to notify the view or obtain data from the view
        public event EventHandler<NotificationEventArgs<Exception>> ErrorNotice;

        #endregion

        #region Properties

        // TODO: Add properties using the mvvmprop code snippet

        #endregion

        #region Methods

        // Set the model to a new Worker
        public void NewWorker()
        {
            base.Model = serviceAgent.CreateWorker();
        }

        #endregion

        #region Commands

        public ICommand NewWorkerCommand
        {
            get
            {
                return new DelegateCommand(NewWorker);
            }
        }

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