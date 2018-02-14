
# FantaCode Internship
# WEEK 12:Report 

###### Date: 14/02/2018
### Tasks 

The resource for this week is here:<br>
<b>Dependency Injection (DI)</b>
* https://developer.xamarin.com/guides/xamarin-forms/enterprise-application-patterns/dependency-injection/
* https://xamarinhelp.com/xamarin-forms-dependency-injection/
* https://www.youtube.com/watch?v=YZKaNsIQp8o
* This article will introduce you to a library and different frameworks that can be used for coding in MVVM Pattern.
https://xamgirl.com/prism-in-xamarin-forms-step-by-step-part-1/


<b>Task</b> : Create an application using Prism and implementing DI.
### Tasks done:

* Read the documentation given above on Dependency Injection. Watched the video tutorial of Houssem Dellai using Prism. The blog by xamgirl was pretty easy and could understand better.
* To get a better idea, I went forward to refer other sources and found the below quite useful:<br>

  <b>Prism for Xamarin Forms</b>
   <br>https://dzone.com/articles/prism-for-xamarin-forms-an-overview-part-1
<br>https://dzone.com/articles/prism-for-xamarin-forms-part-2-basic-navigation-an
<br>https://dzone.com/articles/prism-for-xamarin-forms-part-3-advanced-navigation?fromrel=true<br>
  
  <b>Implementing NavigationService for Xamarin Forms and MVVM ( by Houssem Dellai )</b>
  <br>https://channel9.msdn.com/Blogs/MVP-Windows-Dev/Implementing-NavigationService-for-Xamarin-Forms-and-MVVM
  
  <b>The Xamarin Show: Prism for Xamarin.Forms with Brian Lagunas and James Montemagno</b>
  <br>https://channel9.msdn.com/Shows/XamarinShow/Prism-for-XamarinForms-with-Brian-Lagunas
* Points noted:<br>
  - Prism is a framework which embraces best coding practices to develop loosely coupled, maintainable, and testable applications.
    It basically allows us to use MVVM technique more comfortably. It also allows us to deal with navigation, passing parameters and         commands easily which can often get complex using the MVVM technique without any framework.
  - Dependency Injection : This is used to create loosely coupled dependencies. Here dependencies involve those between views,services       and viewmodels. This architecture also enables one to access platform specific code for Android or iOS from a shared PCL project.
    It’s common to use DI container frameworks to simplify object creation. These frameworks are available as nuget packages like             Ninject, Autofac, TinyIoc, StructureMap. Here I have used Unity in my application.
* Steps followed:<br>
  <br> I tried to use Prism and implement DI in Bubbles application.
  I followed the steps as given in https://xamgirl.com/prism-in-xamarin-forms-step-by-step-part-1/
1. Installed the Prism package : Prism.Unity.Forms <a href="https://www.nuget.org/packages/Prism.Unity.Forms/" rel="nofollow"><img src="https://camo.githubusercontent.com/709fd2a23b7675bb66f11291ffd20e81fdb43f5c/68747470733a2f2f696d672e736869656c64732e696f2f6e756765742f767072652f507269736d2e556e6974792e466f726d732e737667" alt="UnityFormsNuGetShield" data-canonical-src="https://img.shields.io/nuget/vpre/Prism.Unity.Forms.svg" style="max-width:100%;"></a>
1. Added the Prism reference xmlns:prism=“clr-namespace:Prism.Unity;assembly=Prism.Unity.Forms“ in App.xaml.cs, and replaced “Application” Root for “PrismApplication”
1. In App class inherit from PrismApplication, add the Prism initializer parameter in the constructor and override the OnInitialized and RegisterTypes methods on App.xaml.cs 
1. Added Platform initializers on iOS AppDelegate.cs and Android MainActivity.cs
1. Connected Views with View Models:
   ```
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<CameraPage, CameraPageViewModel>();
            containerRegistry.RegisterForNavigation<SpeakPage, SpeakPageViewModel>();
   ```
1. For Navigation from one page to another , used DelegateCommand as in https://channel9.msdn.com/Blogs/MVP-Windows-Dev/Implementing-NavigationService-for-Xamarin-Forms-and-MVVM

1. Registered the services :
Before registering the services, interfaces were created for each service. (Note: static methods cannot be implemented)
   ```
            containerRegistry.Register<IVisionAPI, VisionAPIService>();
            containerRegistry.Register<IAudioRecordService, AudioService>();

   ```
1. Uploaded the application on github :<br>https://github.com/liyanafzl/TasksFantacode/tree/master/Task12/Module13


  

