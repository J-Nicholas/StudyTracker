# StudyTracker
Study Tracker app that I created using C# to track how much time I spend studying topics. 

### Home Screen
I prototyped the UI in Photoshop to see what worked and then used colour pallette when programming all of the UI elements.
The home screen contains a list most recent study logs which are pulled from a JSON file stored in the study tracker's directory.
The logs can be edited or deleted from the home screen. 
The JSON file is updated after every study session, every edit to a log or after deletion of a log.<br><br>
<img src="https://imgur.com/sd4htyK.png" width="400" height="390" alt="HomeScreen">

### Study Session Setup
The session setup screen allows you to choose a topic, which can also be saved to file and chosen from a drop down list of topics next time for convenience.
The setup screen also detects current time and date for time tracking and an optional description box to describe what it is you are studying.
<br><br><img src="https://imgur.com/xWaSKkh.png" width="400" height="390" alt="Study Session Setup 1">
<img src="https://imgur.com/NGR66ov.png" width="400" height="390" alt="Study Session Setup 2">

### Study Timer
The timer screen acts as a stopwatch with pause and resume functionality so breaks can be taken during study sessions and time studied is tracked effectively.
<br><img src="https://imgur.com/NExiUMY.png" width="400" height="390" alt="Study Timer Setup 1">
<img src="https://imgur.com/q1xPT2P.png" width="400" height="390" alt="Study Timer Setup 2">

### Database View
Once a log has been created by either clicking finish on the timer screen or by adding one manually, the database view of the logs becomes available.
In the databse view, all logs are visible and can be edited directly changes won't be saved unless the user clicks save.
<br><br><img src="https://imgur.com/Acs8Zdt.png" width="800" height="500" alt="Database view"><br>
The database offers the ability to add new logs manually as well as the option to filter results based on topic, time period e.g. last two weeks or by a certain date.
<br>
<img src="https://imgur.com/70L17Sw.png"  alt="Database Filter">

### Statistics View
Statistics are also available based on all study logs and give an overview of how time is being spent.
<img src="https://imgur.com/JYbKbLI.png" width="580" height="375" alt="Statistics View">

### YouTube Video
[Study Tracker Video](https://www.youtube.com/watch?v=35D8z7hF6qM)
