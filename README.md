# LegacyXSolution
### by Robert Kelly
LegacyX Take-Home Technical Interview Challenge

## Implementaion Plan
  > My understanding of the problem has the user entering 2 numbers at a time to see the result. The page opens with a title in the top middle, underneath the title in the following order there are 4 boxes, 1. Input Box, 2. Dropdown, 3. Input Box, 4. Button. Underneathe the boxes, there will be 3 Buttons, Show History, Save History and Clear History. These buttons will interact with the table CalculationHistory, which when visible will be below the buttons.
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
  ```csharp
    if(showHistory = clicked)
      history.visible = !history.visible;
    }
  ```
  
  ### clearCalculationHistory
  ```csharp
    if(clearHistory = clicked)
    {   
      // modal popup with question "Are you sure you want to delete current History?"
      if(modalButton = confirm)
      {
        create new CalculationHistory;
        currentCalculationHistory = newCalculationHistory;
      } else 
      {
        close modal
      }
    }
  ```
  
  ### saveCalculationHistory
  ```csharp
    if(saveHistory = clicked)
    {
      // query for download path;
      // create text file with CalcutionHistory printed in order
      // modal popup with question "Would you like to start new Calculation Group?"
      //    if yes
      //      call clearCalculationHistory()
      //    if no
      //      close modal
    }
  ```
  
  ### calculate
  ```csharp
    if(validationErrors = null)
    {
      create new SingleCalulation;
      SingleCalculation.values = current.values;
      CalculationHistory.add(SingleCalculation);

      // return inputBox1 to default;
      // return inputBox2 to default;
      // do not change symbol dropdown
    } else
    {
      display errors
    }
  ```
  
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
