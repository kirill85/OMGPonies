WPF Sample for Simple Mvvm Toolkit

This demonstrates how to use the Simple Mvvm Toolkit to create a WPF MVVM app.

The setup is basically the same as for the Siverlight Getting Started app,
the main difference being that you need to reference SimpleMvvmToolkit-WPF.

Add refences to System.Windows.Interactivity and Microsoft.Expression.Interactions
They can be found here:
C:\Program Files (x86)\Microsoft SDKs\Expression\Blend\.NETFramework\v4.0\Libraries

Don't forget to reference the namespaces in XAML, like so:

xmlns:i="http://schemas.microsoft.com/expression/2010/interactivity"
xmlns:ei="http://schemas.microsoft.com/expression/2010/interactions"

VERSION 2 UPDATE: Two changes were required for version 2 of the Simple MVVM Toolkit.
1) Removed and re-added ViewModelLocator using the new locator item template
   - Used mvvmlocator and mvvmlocatornosa code snippets to add ViewModels
2) Removed square brackets in DataContext for ProductListView and ProductDetailView
   - This references a property in the locator rather than an indexer

Then you can insert event triggers like so:

<i:Interaction.Triggers>
    <i:EventTrigger EventName="Click">
        <ei:CallMethodAction 
                TargetObject="{Binding}"
                MethodName="NewCustomer"/>
    </i:EventTrigger>
</i:Interaction.Triggers>

This provides a starter project with sample code files for models, view-models,
views, services and a locator.

1. Using Customer.cs as an example, create one or more model classes,
   each deriving from ModelBase<TModel>.
   - Add them to the Models folder
   - Use the mvvmprop code snippet to insert properties that support
     two-way data binding.

2. Using ICustomerServiceAgent.cs as an example, create a service agent interface
   with methods to create, retrieve, update or delete entities (CRUD operations).
   - Add it to the Services folder

3. Using MockCustomerServiceAgent.cs as an example, create a class that implements
   ICustomerServiceAgent with fake in-memory entities.
   - Add it to the Services folder
   - A real service agent would most likely obtain entities from either a SOAP
     WCF Service or a WCF RIA Service, which would in turn use a data store for
	 entity persistence.

4. Using CustomerViewModel.cs as an example, add a class that derives from
   ViewModelBase<TViewModel> (to show a list of entities) or ViewModelDetailBase
   <TViewModel, TModel> (to show an individual entity) to the ViewModels folder.
   - Pass the service agent interface to a ctor
   - Then call the service agent methods to perform CRUD operations
   - You can add bindable properties using the mvvmprop code snippet

5. Open ViewModelLocator.cs and use the mvvmlocator code snippet to add ViewModels
   that require a service agent.
   - Use the mvvmlocatornosa code snippet to add ViewModels which do not require
     a service agent (for example, a MainPageViewModel).

6. App.xaml already adds the ViewModelLocator to Application Resources.
   - Views will bind directly to the locator using {StaticResource Locator}

7. Using CustomerView.xaml as an example, add Views to the Views folder.
   - So all you have to do is bind the DataContext of the View to the locator
     stored in the Application Resources, specifying the desired ViewModel
	 in the Binding Path.

	 DataContext="{Binding Source={StaticResource Locator}, Path=CustomerViewModel}"

   - Individual elements on the View only need specify a property on the ViewModel
     for the binding Path (the binding Source is set to the DataContext).
   - DetailViewModels have a Model property that exposes an individual entity,
     so you simply refer to properties of the model.

	<TextBox Grid.Row="0" Grid.Column="1" Height="30"
        Text="{Binding Path=Model.CustomerId}" />

