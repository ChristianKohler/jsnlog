[Read this if forking this repo](#forking)

# JSNLog

JSNLog lets you insert loggers in your client side JavaScript, configure them via a configuration file on the web server, and store their messages in your server side logs - without any server side coding.

Visit [jsnlog.com](http://www.jsnlog.com) to:

* Download and install JSNLog; 
* Get started quickly with JSNLog;
* Get full documentation.

License:
[MIT](https://raw.githubusercontent.com/mperdeck/jsnlog/master/License)

## Why JSNLog?

JSNLog lets you log events in your client side JavaScript code, get that log data back to your web server and store it there.

This makes it different from other JavaScript logging libraries. These either focus on logging to the browser's console, making them useful only during debugging. Or they are essentially ports of log4j to JavaScript, making them rather bloated.

Recognizing that JSNLog runs as part of a JavaScript program on the browser has led to these design choices:

* JSNLog has to travel over the Internet to the browser - so its file size has been kept to a minimum;
* It has many options that allow you to keep the amount of log data going back to the server to a minimum - such as suppressing duplicate log messages, batching of messages and filtering by browser type.
* Having a good JavaScript library is not enough, because the web server is very much part of the equation. Therefore:
   * JSNLog includes server side code that receives log data from the JavaScript library and hands it to a server side logging package for storage on the server;
   * It lets you configure your loggers via a configuration file on the server, so you don't have to change your JavaScript code.

The integration with the web server is currently only available in .Net environments - see [jsnlog.com](http://www.jsnlog.com).

If you do not use .Net, the JavaScript library works very well on its own - see [js.jsnlog.com](http://js.jsnlog.com).

## Contributors welcome

Contributors are very much welcome on the JSNLog project: 
* you will have a lot of autonomy from day one, 
* you'll mostly write new code rather than bug fixes,
* you'll produce a recognizable part of the system.

As described above, a major design feature of JSNLog is its integration with the web server. And that integration currently has only been implemented for .Net environments.

I am looking for people who are familiar with a Linux based web technology such as PHP or Java, and who want to write server side code that:

* Receives log data from the JSNLog.js JavaScript library and stores it on the server, for example by handing it to a server side logging package such as Log4J.

* Allows a web master to configure JSNLog loggers via a server side configuration file. When a page is requested, your code would read the configuration in the file and write JavaScript into the page that configures the JavaScript loggers.

Essentially, this would be your own project, with its own Github page. But you would be leveraging the work already done to develop the JSNLog.js library. Your focus would be on the server side, leaving the JavaScript library as is.

Once your first version has gone live, you'll get a permanent link from jsnlog.com to your project page. This makes it easier for people to appreciate your work, whilst maintaining your autonomy to run your project in your own way.

To see what is involved in integrating the JSNLog JavaScript logging library with your server environment, have a look at:
* [Format of log messages](http://js.jsnlog.com/Documentation/DownloadInstall)
* [JSNLog.js documentation](http://js.jsnlog.com/Documentation/JSNLogJs)

For inspiration, you may want to have a look at the way integration with the web server has been done for .Net:
* http://jsnlog.com

All communication is via the issues page of the JSNLog project on Github. Feel free to say hello, ask any questions or raise any issues:
https://github.com/mperdeck/jsnlog/issues?state=open

<a name="forking"></a>
## Forking

When doing a rebuild of the entire solution, you will probably get the error message:
* Could not copy the file ...\jsnlog.js because it was not found

In the Visual Studio Solution Explorer, in project JSNLog.Tests, remove Scripts/libs/jsnlog.js
This removes a file link (which I use locally in my environment), allowing Visual Studio to pick up the actual file.

When running the tests in JSNLog.Tests, leave out zNuGetTestCommon. It attempts to test installation of the NuGet package, but is very fragile.

Matt Perdeck


