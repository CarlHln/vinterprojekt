using Raylib_cs;

Raylib.InitWindow(800,550, "FRÅGOR");
Raylib.SetTargetFPS(60);
Texture2D background = Raylib.LoadTexture("backgrounda.png");
string currentScene = "mainmenuscreen";
int score = 0;
while (Raylib.WindowShouldClose()==false) {

 //logik
    if(currentScene == "mainmenuscreen"){
        if(Raylib.IsKeyDown(KeyboardKey.KEY_ENTER)){
            currentScene = "beginQ1";
        }
    }

    if(currentScene == "beginQ1") {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A)){
            currentScene = "correctQ2";
            score++;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_B)){
            currentScene = "incorrectQ2"; 
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_C)){
            currentScene = "incorrectQ2"; 
        }
    }

    if(currentScene == "correctQ2"){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_F)){
            currentScene = "correctQ3";
            score++;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_E)){
            currentScene = "incorrectQ3"; 
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_D)){
            currentScene = "incorrectQ3"; 
        }
    }

    if(currentScene == "incorrectQ2"){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_F)){
            currentScene = "correctQ3";
            score++;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_E)){
            currentScene = "incorrectQ3"; 
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_D)){
            currentScene = "incorrectQ3"; 
        }
    }

    if(currentScene == "correctQ3"){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_H)){
            currentScene = "correctQ4";
            score++;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_G)){
            currentScene = "incorrectQ4"; 
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_I)){
            currentScene = "incorrectQ4"; 
        }
    }

    if(currentScene == "incorrectQ3"){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_H)){
            currentScene = "correctQ4";
            score++;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_G)){
            currentScene = "incorrectQ4"; 
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_I)){
            currentScene = "incorrectQ4"; 
        }
    }

     if(currentScene == "correctQ4"){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_L)){
            currentScene = "correctEnd";
            score++;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_K)){
            currentScene = "incorrectEnd"; 
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_J)){
            currentScene = "incorrectEnd"; 
        }
    }

    if(currentScene == "incorrectQ4"){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_L)){
            currentScene = "correctEnd";
            score++;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_K)){
            currentScene = "incorrectEnd"; 
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_J)){
            currentScene = "incorrectEnd"; 
        }
    }

    if(currentScene == "correctEnd"){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE)){
            currentScene = "mainmenuscreen";
            score = 0;
        }
    }

    if(currentScene == "incorrectEnd"){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE)){
            currentScene = "mainmenuscreen";
            score = 0;
        }
    }


//rita
//utseended för alla sidor 
    if (currentScene == "mainmenuscreen"){
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawText(" Welcome to a random quiz, press ENTER to start.", 0,275,30, Color.RED); 
        Raylib.DrawText($"Score: {score}/4",0,500,30, Color.RED); 

    }

    else if (currentScene == "beginQ1") {
        Raylib.DrawTexture(background, 0,0, Color.WHITE);
        Raylib.DrawText(" What is 10 + 4 ?", 0,0,30, Color.RED);
        Raylib.DrawText("Give your answer to continue.",5,40,30,Color.BLACK);
        Raylib.DrawText("a= 14, b=18, c=24",5,70,30,Color.BLACK); 
        Raylib.DrawText($"Score: {score}/4",0,500,30, Color.RED); 
    }

    else if(currentScene == "correctQ2"){
        Raylib.DrawTexture(background, 0,0, Color.WHITE);
        Raylib.DrawText("You were correct, continue with the next question.",5,0,30,Color.BLACK);
        Raylib.DrawText("What is the age of a person born in the year 2005?", 5,40,25, Color.RED);
        Raylib.DrawText("Give your answer to continue.",5,80,30,Color.BLACK);
        Raylib.DrawText("d= 16, e=24, f=18",5,120,30,Color.BLACK); 
        Raylib.DrawText($"Score: {score}/4",0,500,30, Color.RED); 
    }

    else if(currentScene == "incorrectQ2"){
        Raylib.DrawTexture(background, 0,0, Color.WHITE);
        Raylib.DrawText("You were incorrect, continue with the next question.",5,0,25,Color.BLACK);
        Raylib.DrawText("What is the age of a person born in the year 2005?", 5,40,25, Color.RED);
        Raylib.DrawText("Give your answer to continue.",5,80,30,Color.BLACK);
        Raylib.DrawText("d= 16, e=24, f=18",5,120,30,Color.BLACK);
        Raylib.DrawText($"Score: {score}/4",0,500,30, Color.RED); 
    }

    else if(currentScene == "correctQ3"){
        Raylib.DrawTexture(background, 0,0, Color.WHITE);
        Raylib.DrawText("You were correct, continue with the next question.",5,0,30,Color.BLACK);
        Raylib.DrawText("What color is milk?", 5,40,25, Color.RED);
        Raylib.DrawText("Give your answer to continue.",5,80,30,Color.BLACK);
        Raylib.DrawText("g= red, h=white, i=yellow",5,120,30,Color.BLACK);
        Raylib.DrawText($"Score: {score}/4",0,500,30, Color.RED); 
    }

    else if(currentScene == "incorrectQ3"){
        Raylib.DrawTexture(background, 0,0, Color.WHITE);
        Raylib.DrawText("You were incorrect, continue with the next question.",5,0,25,Color.BLACK);
        Raylib.DrawText("What color is milk?", 5,40,25, Color.RED);
        Raylib.DrawText("Give your answer to continue.",5,80,30,Color.BLACK);
        Raylib.DrawText("g= red, h=white, i=yellow",5,120,30,Color.BLACK);
        Raylib.DrawText($"Score: {score}/4",0,500,30, Color.RED); 
    }

    else if(currentScene == "correctQ4"){
        Raylib.DrawTexture(background, 0,0, Color.WHITE);
        Raylib.DrawText("You were correct, continue with the next question.",5,0,30,Color.BLACK);
        Raylib.DrawText("What game is a FPS?", 5,40,25, Color.RED);
        Raylib.DrawText("Give your answer to continue.",5,80,30,Color.BLACK);
        Raylib.DrawText("j=terarria, k=minecraft, l=valorant",5,120,30,Color.BLACK);
        Raylib.DrawText($"Score: {score}/4",0,500,30, Color.RED); 
    }

    else if(currentScene == "incorrectQ4"){
        Raylib.DrawTexture(background, 0,0, Color.WHITE);
        Raylib.DrawText("You were incorrect, continue with the next question.",5,0,25,Color.BLACK);
        Raylib.DrawText("What game is a FPS?", 5,40,25, Color.RED);
        Raylib.DrawText("Give your answer to continue.",5,80,30,Color.BLACK);
        Raylib.DrawText("j= terarria, k=minecraft, l=valorant",5,120,30,Color.BLACK);
        Raylib.DrawText($"Score: {score}/4",0,500,30, Color.RED); 
    }

    else if(currentScene == "correctEnd"){
        Raylib.DrawTexture(background, 0,0, Color.WHITE);
        Raylib.DrawText("You were correct, this quiz has ended.",5,0,25,Color.BLACK);
        Raylib.DrawText("Press SPACEBAR to restart the test.",5,50,30,Color.BLACK);
        Raylib.DrawText($"Score: {score}/4",0,500,30, Color.RED); 

    }

    else if(currentScene == "incorrectEnd"){
        Raylib.DrawTexture(background, 0,0, Color.WHITE);
        Raylib.DrawText("You were incorrect, this quiz has ended.",5,0,25,Color.BLACK);
        Raylib.DrawText("Press SPACEBAR to restart the test.",5,50,30,Color.BLACK);
        Raylib.DrawText($"Score: {score}/4",0,500,30, Color.RED); 
    }

Raylib.EndDrawing();
}