# LegacyXSolution
LegacyX Take-Home Technical Interview Challenge

## Functions
  ### showHistory
  
  ### deleteHistory
  
  ### saveHistory
  
  ### editHistory
  
  ### calculate
  
## Entities
  ### SingleCalculation
    internal partial class SingleCalculation
      {
        public int CalculationID {get;set;}

        public int FirstValue {get;set;}

        public int Symbol {get;set;}

        public int Second Value {get;set;}

        public virtual GroupCalculation GroupCalculation {get;set;}
      }
  
  ### GroupCalculation
    internal partial class GroupCalculation
    {
      public int GroupCalculationID {get;set;}

      public virtual ICollection<SingleCalculation> SingleCalculations {get;set;}
    }
