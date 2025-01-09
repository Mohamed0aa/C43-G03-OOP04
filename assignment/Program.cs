using System.Runtime.Intrinsics.X86;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            
            #region q1 :What is the primary purpose of an interface in C#?
            //b) To define a blueprint for a class
            #endregion
            #region q2 :Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            #endregion
            #region q3 :Can an interface contain fields in C#?
            //NO
            #endregion
            #region q4 :In C#, can an interface inherit from another interface?

            //yes
            #endregion

            #region q5 :Which keyword is used to implement an interface in a class in C#?
            //d) implements
            #endregion
            #region q6 : Can an interface contain static methods in C#?
            // yes
            #endregion
            #region q7 :In C#, can an interface have explicit access modifiers for its members?

            //b) No, all members are implicitly public
            #endregion
            #region q8 :What is the purpose of an explicit interface implementation in C#?
            //b) To provide a clear separation between interface and class members
            #endregion
            #region q9 : In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors
            #endregion
            #region q10 :How can a C# class implement multiple interfaces?
            // c) By separating interface names with commas
            #endregion
            #endregion
            
            #region part2
            #region  q1
            // Circle circle = new Circle();
            //circle.Radius = 14.4;
            //Console.WriteLine("Circle");
            //circle.DisplayShapeInfo();
            //Rectangle rectangle = new Rectangle();
            //Console.WriteLine("Rectangle");
            //rectangle.width= 10;
            //rectangle.height= 5;
            //rectangle.DisplayShapeInfo();
            #endregion


            //mohamed


            #region q2
            //IAuthenticationService authenticationService = new BasicAuthenticationService();
            //bool ch = authenticationService.Authenticate("Mohamed", "##########");
            //bool ch2 = authenticationService.AuthorizeUser("Admin");
            //Console.WriteLine($"authentication_state is {ch} ");//true
            //Console.WriteLine($"Authorization_state is {ch2}");//true
            #endregion

            #region q3
            //INotificationService pushNotificationService = new PushNotificationService();
            //INotificationService email = new EmailNotificationService();
            //INotificationService sms = new SmsNotificationService();
            //pushNotificationService.SendNotification("moahmed", " dont bs]e lazy ");
            //sms.SendNotification("123445544454", " dont bs]e foolish ");
            //pushNotificationService.SendNotification("moahmed@gmail.com ","work harder ");
            

            #endregion
            #endregion
        }
    }
}
