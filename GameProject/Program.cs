using System;
Console.Clear();

string[,] menu = {{"@", "Начать игру", " "},
                  {" ", "Выбор уровня", " "},
                  {" ", "Выход", " "}};

string[,] Levels = {{"@", "Уровень 1", " "},
                    {" ", "Уровень 2", " "},
                    {" ", "Уровень 3", " "},
                    {" ", "Уровень 4", " "},
                    {" ", "Уровень 5", " "},
                    {" ", "Уровень 6", " "},
                    {" ", "Назад", " "},};

string[,] matrix = {{" "," "," "," "," "},
                    {" "," "," "," "," "},
                    {" "," ","@"," "," "},
                    {" "," "," "," "," "},
                    {" "," "," ","$"," "},
                    {" "," "," "," "," "}};
Dictionary<int, string[,]> Lvls =  new Dictionary<int, string[,]>{{1,
new string[,]{{" "," "," "," "," "},
              {" "," "," "," "," "},
              {" "," ","@"," "," "},
              {" "," "," "," "," "},
              {" "," "," ","$"," "},
              {" "," "," "," "," "}}},
              {2,
new string[,]{{" "," "," "," "," "},
              {" ","|"," ","|"," "},
              {" ","|","@","|"," "},
              {" "," "," "," "," "},
              {" "," "," ","$"," "},
              {" "," "," "," "," "}}},
              {3,
new string[,]{{"_","_","_","_","_"},
              {" "," "," "," "," "},
              {" "," ","@","|"," "},
              {" ","|"," "," "," "},
              {" "," "," ","$"," "},
              {" "," "," ","|"," "}}},
              {4,
new string[,]{{" "," "," "," "," "},
              {" "," "," ","|"," "},
              {" "," ","@","|"," "},
              {" "," ","_","_"," "},
              {" "," "," ","$"," "},
              {" "," "," "," "," "}}},
              {5,
new string[,]{{" "," ","_ "," "," "},
              {" ","|"," ","|"," "},
              {" ","|","@","|"," "},
              {" ","|"," ","|"," "},
              {" "," "," ","$"," "},
              {" "," "," "," "," "}}},               
              {6, 
new string[,]{{" "," "," "," "," "},
              {" "," "," ","|"," "},
              {" "," ","@","|"," "},
              {" ","_","_","_"," "},
              {" "," "," ","$"," "},
              {" "," "," "," "," "}}}};
int coins = 0;
int MenuX = 0;
int MenuY = 0;

int SelectMenuPlayer() 
{
    int indexMenu = 0;
    MatrixWrite(menu);
    ConsoleKeyInfo UserKeyTab = Console.ReadKey();
    while(UserKeyTab.Key != ConsoleKey.Enter)
    {
        Console.Clear();
        menu[MenuY, MenuX] = " ";
        if (UserKeyTab.Key == ConsoleKey.W && indexMenu > 0)
        {
            indexMenu--;
            MenuY--;
        }
        if (UserKeyTab.Key == ConsoleKey.S && indexMenu < 2)
        {
            indexMenu++;
            MenuY++;
        }
        menu[MenuY, MenuX] = "@";
        MatrixWrite(menu);
        UserKeyTab = Console.ReadKey();
    }
    return indexMenu;
}

int SelectLvlGame() 
{
    int indexLevels = 0;
    MatrixWrite(Levels);
    ConsoleKeyInfo UserKeyTab = Console.ReadKey();
    while(UserKeyTab.Key != ConsoleKey.Enter)
    {
        Console.Clear();
        Levels[MenuY, MenuX] = " ";
        if (UserKeyTab.Key == ConsoleKey.W && indexLevels > 0)
        {
            indexLevels--;
            MenuY--;
        }
        if (UserKeyTab.Key == ConsoleKey.S && indexLevels < 7)
        {
            indexLevels++;
            MenuY++;
        }
        Levels[MenuY, MenuX] = "@";
        MatrixWrite(Levels);
        UserKeyTab = Console.ReadKey();
    }
    return indexLevels;
}

void MatrixWrite(String[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Кол-во очков " + coins);
}

string[,] ItemFootMatrix(int x, int y, string[,] array) 
{
    while(matrix[y,x] == "$")
    {
        matrix[y,x] = " "; 
        int matX = new Random().Next(0, array.GetLength(1));
        int matY = new Random().Next(0, array.GetLength(0));
        while(matrix[matY,matX] == "O") 
        {
        matX = new Random().Next(0, array.GetLength(1));
        matY = new Random().Next(0, array.GetLength(0));
        }
        if (matX == 0) matX = array.GetLength(1)-2; 
        if (matX == array.GetLength(1)-1) matX = 1; 
        if (matY == 0) matY = array.GetLength(0)-2; 
        if (matY == array.GetLength(0)-1) matY = 1; 
        array[matY, matX] = "$"; 
        coins++;
    }
    return array;
}

bool Barrier(int x, int y)
{
    if (matrix[y,x] == "O") return false;
    return true;
}
int x = 1;
int y = 1;
Start();

void Start(){
while (true)
{
    switch (SelectMenuPlayer())
    {
        case 0: 
            Console.Clear();
            Game();
            break;
        case 1: 
            Console.Clear();
            menu[MenuY, MenuX] = " ";
            MenuX = 0;
            MenuY = 0;
            menu[MenuY, MenuX] = "@";
            while(true)
            {
                switch (SelectLvlGame()) 
                {
                    case 0: 
                            Game();
                            break;
                    case 1: 
                            matrix = Lvls[2];
                            Game();
                            break;
                    case 2: 
                            matrix = Lvls[3];
                            Game();
                            break;
                    case 3: 
                            matrix = Lvls[4];
                            Game();
                            break;
                    case 4: 
                            matrix = Lvls[5];
                            Game();
                            break;
                    case 5: 
                            matrix = Lvls[6];
                            Game();
                            break;
                    case 6: 
                            Console.Clear();
                            Levels[MenuY,MenuX] = " ";
                            MenuX = 0;
                            MenuY = 0;
                            Levels[MenuY,MenuX] = "@";                        
                            Start();
                            break;
                    default:
                            break;
                }
            }            
        case 2: 
            Console.Clear();
            break;
        default:
            break;
    }
}

    void Game() 
    {
        while (true)
        {   
        Console.Clear();
        MatrixWrite(matrix);
        matrix[y,x] = " ";
        ConsoleKeyInfo UserKeyTab = Console.ReadKey();
        if (UserKeyTab.Key == ConsoleKey.W) if(Barrier(x,y-1)) y--;
        if (UserKeyTab.Key == ConsoleKey.S) if(Barrier(x,y+1)) y++;
        if (UserKeyTab.Key == ConsoleKey.A) if(Barrier(x-1,y)) x--;
        if (UserKeyTab.Key == ConsoleKey.D) if(Barrier(x+1,y)) x++;

        if (y >= ((matrix.GetLength(0))-1)) y = 1; 
        if (y < 1) y = matrix.GetLength(1)-2; 
        if (x >= matrix.GetLength(1)-1) x = 1; 
        if (x < 1) x = matrix.GetLength(1)-2;

        matrix = ItemFootMatrix(x, y, matrix);
        matrix[y,x] = "@";
        }
    }
}



