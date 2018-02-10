# FantaCode Internship
# WEEK 11:Report 

###### Date: 11/02/2018
### Tasks 

The task for the next week is here:<br>

1. <b>Advanced MVVM</b>
    1. Advanced MVVM - https://www.youtube.com/watch?list=PLpbcUe4chE7-uGCH1S0-qeuCWOMa2Tmam&v=L6EsshOGmZs
    1. View Model Locator and Application.Resource - https://www.youtube.com/watch?list=PLpbcUe4chE7-uGCH1S0-qeuCWOMa2Tmam&v=L6EsshOGmZs
    1. Advanced Xamarin Forms UX - https://www.youtube.com/watch?list=PLpbcUe4chE7-uGCH1S0-qeuCWOMa2Tmam&v=WByQQwctYgI

### Tasks done:

* Watched the video tutorials and understood the concept of using Application Resources and ViewModelLocator.
* Points noted-<br>
  * Suppose that we are using the same view model for 2 or more views. We would possibly create a new instance of the view model in each of the pages/views. Instead of creating a new instance of the view model each time, we could use Application Resources. (It is something like making a variable global. Thus we would have to define it only once and it can be accessed everywhere.) Therefore to extend the scope of any object to the entire application, it needs to be defined in Application Resources as follows:<br>
    * In App.xaml, add the viewmodel in ResourceDictionary as given below:
    
    ```
        <Application.Resources>
       	  <ResourceDictionary>
       	               <ViewModels:MainViewModel x:Key="MainViewModel"/>
       	       </ResourceDictionary>
	    </Application.Resources>
	    
	   ```
     * Add the namespace accordingly. (Here: xmlns:ViewModels="clr-namespace:App1.ViewModels;assembly=App1")
     * Add the BindingContext in MainPage as well as the other two pages which use the same viewmodel.
     ```
     	BindingContext = "{StaticResource MainViewModel}"
	```
  * But the above method cannot be used in cases where the view model constructor is parameterized. This is where ViewModelLocator is used.
	* To use ViewModelLocator , create a new folder named Configuration --> add new class named ViewModelLocator -->make it public -->add a property of type MainViewModel --> in the constructor create an instance of the view model.
	* In App.xaml, change the code as follows:
	```
        <Application.Resources>
       	  <ResourceDictionary>
       	               <Configuration:ViewModelLocator x:Key="ViewModelLocator"/>
       	       </ResourceDictionary>
	    </Application.Resources>
	    
	   ```
	* Change the namespace accordingly.
	* Add the BindingContext in each of the views as follows;
	```
     	BindingContext = "{Binding MainViewModel, Source ={StaticResource ViewModelLocator}"
	```
	
	

