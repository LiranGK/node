using ListLab;
using BagrutListLab;

public class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello, World!");
        Node<int> lst = new Node<int>(5);//יצירת חוליה ראשונה ששם הרשימה מצביע עליה
                                         //null בעת היצירה החוליה היחידה מצביעה על
        Console.WriteLine(lst);
        Node<int> currNode = new Node<int>(7, lst);//יצירת חוליה נוספת, שמוצבת לפני ליסט ומצביעה
                                                   //על החוליה הראשונה של ליסט
        lst = currNode;//גורמים למצביע ליסט להצביע על החוליה שהוספנו בתחילת הרשימה
        Console.WriteLine(lst);
        currNode = new Node<int>(9, lst);
        lst = currNode;
        currNode = new Node<int>(-2, lst);
        lst = currNode;
        currNode = new Node<int>(10, lst);
        lst = currNode;
        currNode = new Node<int>(22, lst);
        lst = currNode;
        currNode = new Node<int>(1, lst);
        lst = currNode;
        currNode = new Node<int>(-1, lst);
        lst = currNode;
        currNode = new Node<int>(-9, lst);
        lst = currNode;
        lst = new Node<int>(-55, lst);//צורת כתיבה שמאפשרת להוסיף חוליה בראש שרשרת החוליות ולהעביר אתיה את מצביע ראש הרשימה
        Console.WriteLine(lst);

        Console.WriteLine(lst.GetValue());//הדפסת הערך של החוליה הראשונה ברשימה

        Console.WriteLine(lst.GetNext().GetValue());//הדפסת הערך של החוליה השנייה ברשימה

        currNode = lst.GetNext();//הצבעה על החוליה השניה בשרשרת החוליות

        currNode = currNode.GetNext();//קידום ההצבעה של החוליות הנוכחית באחת

        //שילוב חוליה חדשה בשרשרת אחרי חוליה נתונה
        //נהנה למשל שרשרת חוליות מסודרת בסדר עולה
        Node<int> lst1 = new Node<int>(10);// 10-->null
        lst1 = new Node<int>(8, lst1);// 8-->10-->null
        lst1 = new Node<int>(6, lst1);// 6-->8-->10-->null
        lst1 = new Node<int>(4, lst1);// 4-->6-->8-->10-->null
        Console.WriteLine(lst1);

        //ניצור חולייה חדשה ונכניס אותה לשרשרת לפי ערך המספר
        Node<int> NewNode = new Node<int>(7);// 7-->null
        currNode = lst1;//הצבעה על החוליה הראשונה בשרשרת
        if (currNode.GetValue() > NewNode.GetValue())
        {
            NewNode.SetNext(lst1);//הצבת החוליה החדשה לפני החוליה הראשונה בשרשרת
            lst1 = NewNode;//ההצבת שם השרשרת על המספר החדש שנוסף בראשה
        }
        else
        {
            while (currNode.HasNext() && currNode.GetNext().GetValue() < NewNode.GetValue())
            {
                currNode = currNode.GetNext();//כל עוד יש חוליה עוקבת והערך שלה קטן מהחוליה החדשה מתקדמים חוליה
            }
            NewNode.SetNext(currNode.GetNext());//הצבת החוליה החדשה לפני החוליה העוקבת את הנוכחית
            currNode.SetNext(NewNode);//הצבת החוליה החדשה אחרי החוליה הנוכחית        
        }
        Console.WriteLine(lst1);

        Node<int> list = new Node<int>(12, new Node<int>(7, new Node<int>(10, new Node<int>(9, new Node<int>(13)))));
        int sum = NodeSum(list);
        int evenAmount = NodeEven(list);
        int biggestNum = BiggestNode(list);
        Console.WriteLine(sum + " " + evenAmount + " " + biggestNum);
        */
        Node<Ranges> rangeList = new Node<Ranges>(new Ranges(-2, -5), new Node<Ranges>(new Ranges(10, 5), new Node<Ranges>(new Ranges(30, 20), new Node<Ranges>(new Ranges(100, 85)))));
        Console.WriteLine(rangeList.ToString());
        bool isIn = IsIn(rangeList, 7);
        Console.WriteLine(isIn);
    }
    public static int NodeSum(Node<int> first) 
    {
        int sum = 0;
        Node<int> nodeCopy = first;
        while (nodeCopy != null)
        {
            sum += nodeCopy.GetValue();
            nodeCopy = nodeCopy.GetNext();
        }
        return sum;
    }
    public static int NodeEven(Node<int> first) 
    {
        int len = 0;
        Node<int> nodeCopy = first;
        while(nodeCopy != null) 
        {
            if (nodeCopy.GetValue() % 2 == 0)
            {
                len++;
            }
            nodeCopy = nodeCopy.GetNext();
        }
        return len;
    }
    public static int BiggestNode(Node<int> first) 
    {
        int biggestNum=-999999999;
        Node<int> nodeCopy = first;
        while (nodeCopy != null)
        {
            if(nodeCopy.GetValue()> biggestNum) 
            {
                biggestNum= nodeCopy.GetValue();
            }
            nodeCopy = nodeCopy.GetNext();
        }
        return biggestNum;
    }
    public static bool IsIn(Node<Ranges> lst, int numToCheck) 
    {
        bool isIn = false;
        Node<Ranges> nodeCopy = lst;
        while (nodeCopy != null)
        {
            if (nodeCopy.GetValue().GetHigh() >= numToCheck && numToCheck >= nodeCopy.GetValue().GetLow()) 
            {
                isIn = true;
            }
            nodeCopy = nodeCopy.GetNext();
        }
        return isIn;
    }
    public static Node<Ranges> AddRangeNode(Node<Ranges> lst, int numToCheck) 
    {
        Node<Ranges> nodeCheckCopy = lst;
        Node<Ranges> nodeChangeCopy = lst;
        bool isIn = IsIn(nodeCheckCopy, numToCheck);
        if (!isIn) 
        {
            if (nodeChangeCopy.GetValue().GetLow() > numToCheck)
            {
                if(numToCheck+5> nodeChangeCopy.GetValue().GetLow()) 
                {
                    if(numToCheck-5< nodeChangeCopy.GetValue().GetHigh())
                    {
                        Node<Ranges> NewNode = new Node<Ranges>(new Ranges();
                    }
                }
                NewNode.SetNext(lst1);
                lst1 = NewNode;
            }
            else
            {
                while (currNode.HasNext() && currNode.GetNext().GetValue() < NewNode.GetValue())
                {
                    currNode = currNode.GetNext();
                }
                NewNode.SetNext(currNode.GetNext());
                currNode.SetNext(NewNode);    
            }
        }
    }
}