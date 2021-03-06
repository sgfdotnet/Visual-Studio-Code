# SPF.NET May 2017: VS Code 

![Logo](/sgfnet-logo-color-light.png)

## Intro

* History
    * "Code editing. Redefined."
    * Announced at the 2015 Build conference
    * Released later that year
    * Since that time have had a roughly monthly release cadence
    * They have added a bunch of stuff
    * Support seems to be very good
    * Can see the latest patch notes [here](https://code.visualstudio.com/updates/v1_12)
    * Latest version added: 1.12
* Basics
    * Based on Electron, which uses web technologies to build desktop apps
    * It is not a form of Atom which is a different text/code editor
    * It is fully cross platform so it runs on Windows, Mac, and Linux
    * I believe that the experience on all of them is the same
* What do people use it for?
    * People use it for everything, Javascript, Go, Python, stuff you have never heard of
    * But of course MS shows it off as part of their .Net Core platform
    * This is fully cross platform .Net framework
    * It is NOT a VS replacement, at least in terms of feature Set
    * Speaking personally, it has replaced VS for a good portion of my personal development
    * I used to use a mixture of Notepad++, Visual Studio, and more when doing web development
    * This was often combined by a few terminal windows, or CMD.exe on Windows
    * VS Code has replaced all of that
    * It has also taken over the role at work of viewing/examining SQL files
    * Instances where I just need to jump in, look at or copy a file, then move on
    * Opens WAY faster than SQL Management Studio or Visual Studio
    * I also use it for note-taking/task lists
* What we are going to cover today
    * How do we install it
    * What does it look like, and an overview of the UI
        * This includes useful shortcuts, the terminal, and wtf the "command palette" is
    * Extensions
        * This is where the real power of VS Code is, a massive and growing ecosystem
        * Has a ton of stuff from language support to fancy git tools 
        * All free, and something you can add today
    * Git
        * We will discuss how VS Code can interact with git
        * It is what the VS Code team uses, and it is the only Version Control in VS Code
        * I'm sure you can already see the little git symbol over on the Side
    * Terminal
        * Lets talk about Terminal
        * That little window at the bottom
    * .Net Core
        * We will close out by installing and working with .Net Core
        * This gives us a chance to talk about the actual coding
        * Will also let us use the built in debugging features, in this case for C#
* Feel free to interrupt at any time

## Install

* Download here [code.visualstudio.com](http://code.visualstudio.com)
* Available on Windows, Mac or Linux
* Won't walk through, it is just an installer

## UI

* Welcome Page
* Useful shortc
    * Quick Open/Command Bar/Command Palette (Ctrl + Shift + P)
    * Terminal (Ctrl + `)
    * Search for Shortcuts
    * Mulit-cursor at end of line Shift+Alt+I
    * File History Ctrl + Tab
    * Auto format: Shift + Alt + F
        * Use jsonexample.txt
        * Switch Language mode to JSON through Command Palette
* Open Folder
* Markdown
    * Allows for Markdown preview (Ctrl+K V)
    * I use Markdown a lot, and I still mess it up sometimes
    * I also have this Markdown linting extension installed
* Search
    * Searches all files in currently open folder
    * Also does replace
* Compare
    * Right click and Select for Compare
    * Right click and Compare To...
* Git
    * A simple Git UI, will discuss more later
* Debug
    * It debugs things, will discuss later
* Extensions
    * This is where VS Code gets fun


## Extensions
### Installing

* Walk through UI
* Command Palette
    * ext install vscode-icons

### Cool Extensions

* C#
* npm
* git history
* Regex
* vscode-icons
* MS SQL
    * Will let you connect to Servers and run some queries
    * Lets you export results as JSON, which I have not seen in an MS product before
* Everybody's extension list would be different
* Some people might use the vim extension, because they are those people
* Some people will use the Python extension, roughly 2 million people
* More at [VS Code Marketplace](marketplace.visualstudio.com/VSCode)
* Thousands of them 
* Show React extensions

## Git

* Fancy Git tab
* Does a lot of the basic stuff that you would expect from a GUI Git client
* I think anybody who does anything in Git generally tells me I should be using the terminal to interact with it
* I like the Git History extension (git log)

## Terminal

* Integrated Terminal Ctrl + ~
* Command Palette -> Default Shell
* Can choose between Powershell (Windows Default), Command Prompt, Git Shell, and WSL Bash (Windows Subsystem for Linux Only)
* Functions like a full terminal, not restricted to just VS Code functionality
* Its a terminal, what more can I say?

## Doing some Development
### Steps
#### Console App
1. dotnet new console -o consoleapp
2. cd consoleapp
3. dotnet restore
4. dotnet run

#### ASP.NET Core App
1. dotnet new mvc -o webapp
2. cd webapp
3. dotnet restore
4. dotnet run

#### Vue.JS App
1. npm install --global vue-cli
2. vue init webpack testapp
3. cd testapp
4. npm install
5. npm run dev

#### React + Typescript App
1. npm install -g create-react-app
2. create-react-app reacttsapp --scripts-version=react-scripts-ts
3. cd reacttsapp
4. npm run start

## Debugging
* Console App