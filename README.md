# Introduction
    HangedManGame(LePendu) is a fun and educational desktop application that brings the classic "Hangman" game to life. Developed in C# using Windows Presentation Foundation (WPF) within Visual Studio, this application offers an engaging user interface where players guess words to prevent the completion of the  hangman's figure. With multiple screens including Home, Preferences, Game, History, and Dictionary, HangedManGame provides an interactive and challenging experience for users of all ages.

# Features
    HangedManGame is packed with features that make learning new words and testing vocabulary skills exciting:

        - Home Screen: Welcomes users and navigates to different sections of the game such as Preferences, Game, and History.
        - Game Mechanics: Players guess letters to form words, with each incorrect guess adding a part to the hangman figure. The game includes a series of buttons representing letters, ensuring each letter can only be selected once.
        - Word Selection: Words are randomly chosen from a predefined list, with hidden letters displayed as stars or other placeholders on the screen.
        - Game Restart: Includes a "Start Game" button to restart the game at any time, with user confirmation.
        - History Screen: Displays a chronological record of played games, including the word, difficulty level, and playtime.
        - Preference Screen: Allows users to select the game language and difficulty level, which remain set between sessions.
        - Dictionary Screen: Users can view, add, and delete words in the dictionary based on selected language and difficulty, with changes being permanent.

# Technologies Used
    HangedManGame is built using modern development tools and frameworks:

        - C#: Programming language for backend logic.
        - WPF (Windows Presentation Foundation): Framework for building rich desktop applications with engaging UI.
        - Entity Framework: Used for database interactions, particularly with SQL Server, to manage the dictionary of words.
        - Visual Studio: Integrated development environment (IDE) for building, debugging, and deploying the application.
        - SQL Server: Database system used to store and manage the game's dictionary and history data.
    
# Getting Started
    To dive into the HangedManGame:
    
        1. Clone the Repository: Get a copy of the source code on your machine.
    
           Copy the following code in the command line: 
           git clone https://github.com/your-username/HangedManGame.git
           
        2. SQL Server Connection Setup: Before running the application, ensure you have SQL Server installed and set up a database connection corresponding to the one specified in the App.config file of the project. 
           
            The relevant section of the App.config looks like this:
            
            <connectionStrings>
                <add name="Jeu_De_Pendu_DB"
                     connectionString="Server=localhost; Database=Jeu_De_Pendu_DB; Integrated Security=True;"
                     providerName="System.Data.SqlClient" />
            </connectionStrings>
            
            This means you need to have a SQL Server instance running on localhost with a database named Jeu_De_Pendu_DB. If your setup differs, adjust the connectionString accordingly.
        
        3. Open the Project: Launch Visual Studio and use it to open the HangedManGame project you just cloned.
        
        4. Database Initialization: Depending on how you've set up Entity Framework, you might need to create and initialize the database before the first run. This could involve running Entity Framework migrations if they are part of your project. 
           Check the project documentation or Entity Framework configuration for specific instructions.
        
        5. Run the Application: Compile and run the application within Visual Studio. This will start the HangedManGame in a WPF window, ready for you to play and explore its features.
        
        6. Enjoy the Game: Navigate from the home screen to start a new game, access game settings, or review your play history. Customize your game experience through the Preferences and Dictionary screens to enhance your gameplay.

# Conclusion
    HangedManGame(LePendu) revitalizes the traditional hangman game with a digital twist, offering an interactive platform for word guessing and vocabulary enhancement. Its user-friendly interface and challenging gameplay make it a suitable choice for individuals seeking a fun and educational pastime on their Windows desktop.
