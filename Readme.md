C# STRING SPLIT METHOD
      **
      used to split a string into substrings based on the characters in an array
      The split method will return a string array which contains a substring that are delimited by a 
      specified characters in an array

    `public string [] Split(char[] separator)`  "syntax"
        `string names = "Audi,Cadillac, Mercedece";`
        `string [] autos = names.Split(',');`
        
  ``
         `StringSplitOptions.RemoveEmptyEntries` property is used to remove an empty string elements while returning the result array.

 
      
      
      **