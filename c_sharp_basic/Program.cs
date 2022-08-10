namespace c_sharp_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new assignment();




            //hello world
            obj.helloWorld();

            //primitive data type printing
            obj.printPrimitiveType();

            //checked exception
            obj.checkedException();
            // type convertion
            obj.typeConvertion();

            //general artithmatic operation
            obj.generalOperation();

            // conditional operation if-elseif-else
            obj.conditionExpression();

            // complex  conditional operation if-elseif-else with && and ||
            obj.muultiLineConditionExpression();


            // ternary logical operators
            obj.ternaryLogicOperation();

            //different types of comment
            obj.differentTypesOfComment();


            //For, While, Do while, Foreach, continue & break (print 1-100, skip at 95, break at 99)
            obj.skip95AndBreaksAt99();

            //switch case
            obj.switchCases();

        }
    }
}