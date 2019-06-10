namespace ReinforcementLearning
{
    //I think this is necessary to help enforce the baseunit type on some calls and dictionary-dereferences
    class UnitBase : Unit
    {
        public override string ToString()
        {
            return "Static " + base.ToString();

        }
    }
}
