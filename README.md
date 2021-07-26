# SportEventsScores

OVERVIEW
- An app that displays the results of the biggest sporting events of 2021
- Great project for practicing C# and WPF while learning to use MVVM
- Disclaimer: when viewing the code use Vertical Split

CODE-BEHIND
- MainWindow remains unchanged while changing Views to display information on top of it
- Clicking on the menu buttons changes the View (i.e. selected sporting event)

    - Home is the default view displayed when running the application
    - CurrentView stores the view that is currently displayed
    - Created a different View and ViewModel for each sporting event 
    - Used Relay Commands to change the CurrentView to the selected View
 
INTERFACE
- The focus of this project was on the UI and UX
- Implemented a minimalistic style to the interface
- Every element and window has rounded corners to mimic MacOS and Windows 11 applications
- Used StackPanels and Grids to organise the Borders that display the scores in each View
