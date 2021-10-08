using System;

namespace ConsoleGame{

  class Game : SuperGame{
    
    public new static void UpdatePosition(string key, out int x, out int y){
      if(key == "DownArrow"){
        x = 0;
        y = 1;
      }
      else if(key == "UpArrow"){
        x = 0;
        y = -1;
      }
      else if(key == "LeftArrow"){
        x = -1;
        y = 0;
      }
      else{
        x = 1;
        y = 0;
      }
    }

    public new static char UpdateCursor(string key){
      if(key == "LeftArrow"){
        return '<';
      }
      else if(key == "RightArrow"){
        return '>';
      }
      else if(key == "UpArrow"){
        return '^';
      }
      else if(key == "DownArrow"){
        return 'v';
      }
      else{
        return '.';
      }
    }
   
    public new static int KeepInBounds(int coordinate, int maxvalue){
      if(coordinate <= 0){
        return 0;
      }
      else if(coordinate >= maxvalue){
        return maxvalue-1;
      }
      else{
        return coordinate;
      }
    }

    public new static bool DidScore(int xChar, int yChar, int xFruit, int yFruit){
      if(xChar == xFruit && yChar == yFruit){
        return true;
      }
      else{
        return false;
      }
    }
  }
}