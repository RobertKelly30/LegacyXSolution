# LegacyXSolution
### by Robert Kelly
LegacyX Take-Home Technical Interview Challenge

## Implementaion Plan
  > The page opens with a title in the top middle, underneath the title in the following order there are 4 boxes, 1. Input Box, 2. Dropdown, 3. Input Box, 4. Button.
  - **ShowHistory_Click**
    - Used to show or hide the history of the current `CalculationHistory`
    - The ShowHistory button will toggle visible on the History `div`
    - The default will be `visible:false`
  - **CalculationHistory_Click**
    - Used to remove current `CalculationHistory`
    - A modal window will pop up asking the user if they are sure they want to clear current `CalculationHistory`
    - If the user selects `yes` then the current history will be overwitten by the creation of a new `CalculationHistory`
  - **SaveHistory_Click**
    - Uses to save current `CalculationHistory`
    - Will download the file as a text file to users default downloads folder
  - **Calculate_Click**
    - Used to add current `SingleCalculation` to current `GroupCalculation`
    - Will validate the current page to make sure both number boxes are filled with valid data
    - If there are no validation errors, the `SingleCalculation` entity will be placed inside the current `CalculationHistory` and create a new `SingleCalculation`

## Functions
  ### showCalculationHistory
  
  ### clearCalculationHistory
  
  ### saveCalculationHistory
  
  ### editCalculationHistory
  
  ### calculate
  
## Entities
  ### SingleCalculation
  ```csharp
    internal partial class SingleCalculation
      {
        public int CalculationID {get;set;}

        public int FirstValue {get;set;}

        public int Symbol {get;set;}

        public int Second Value {get;set;}

        public virtual CalculationHistory CalculationHistory {get;set;}
      }
  ```
  
  ### CalculationHistory
  ```csharp
    internal partial class CalculationHistory
    {
      public int GroupCalculationID {get;set;}

      public virtual ICollection<SingleCalculation> SingleCalculations {get;set;}
    }
  ```
