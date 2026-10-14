namespace Advanced_csh_01
{
    //    #region Part1: Theoritical Questions
    //    //Part1: Theoritical
    //    //Question1:
    //    //a)The value of the first object variable is copied into the other as a value not as a refernce address
    //    //b)No, It creates a new refernce that refers to the same object in heap but it doesnt create a new object
    //    //c)Copying an object is copying its value and assigning it to another object variable while copying its reference is copying its address to the other object variable
    //    //Question2:
    //    //a)A Shallow copy is a copy of the object that shares references to the same objects in memory and the copy and the original are not independent(REFERENCE TYPES)
    //    //b)A deep copy creates a new object and copies all the values and references to new objects in memory and the copy and the original are completely independent
    //    //c)When a shallow copy is made, changes made to the original object will affect the copy and vice versa. 
    //    //d)When a deep copy is made, changes made to the original object will not affect the copy and vice versa.
    //    //e) when you need to modify nested mutable data inside a cloned structure without accidentally changing the values in the original data source
    //    //Question3:
    //    //a)Static field is a field that belongs to the class itself rather than to any specific instance of the class. It is shared among all instances of the class and can be accessed without creating an object of the class. Static fields are typically used to store data that is common to all instances of a class, such as configuration settings or counters.
    //    //while instance field is a field that belongs to a specific instance of a class. Each instance of the class has its own copy of the instance fields, and they can be accessed only through an object of the class. Instance fields are typically used to store data that is unique to each instance of a class, such as the state of an object or its properties.
    //    //b)Static methods are methods that belong to the class itself rather than to any specific instance of the class. They can be called without creating an object of the class and can only access static fields and other static methods of the class. Static methods are typically used for utility functions or operations that do not require access to instance-specific data.
    //    //c)Static constructors are special methods that are called automatically when a class is first loaded into memory. They are used to initialize static fields or perform other one-time setup tasks for the class. Static constructors do not take any parameters and cannot be called explicitly. They are typically used to set up shared resources or perform other initialization tasks that need to be done only once for the entire class.
    //    //d)Static classes are classes that can only contain static members and cannot be instantiated. They are typically used to group related utility functions or constants together in a single class. Static classes cannot have instance constructors or instance fields, and they cannot implement interfaces or inherit from other classes. They are often used for helper classes or libraries that provide functionality that is not tied to any specific object instance.
    //    //Question4:
    //    //a)An Extension method is a special kind of static method that allows you to add new methods to an existing class without modifying its source code or creating a new derived class. Extension methods are defined in static classes and use the "this" keyword in their first parameter to specify the type they are extending. They can be called as if they were instance methods on the extended type, providing a way to enhance the functionality of existing types in a clean and reusable manner..
    //    //b)this is the keyword used in the first parameter of an extension method to specify the type that the method is extending. It allows the method to be called as if it were an instance method on the extended type, providing a way to add new functionality to existing types without modifying their source code or creating a new derived class.
    //    //c)Extension methods are declared in static classes and are themselves static methods. They can be called using the dot notation on instances of the extended type, just like regular instance methods. The first parameter of an extension method specifies the type being extended, and it is preceded by the "this" keyword. This allows the method to be called as if it were a member of the extended type, even though it is defined in a separate static class.
    //    //d)Extension methods can access public members of the type they are extending, but they cannot access private or protected members. They can also access other extension methods defined in the same static class, as well as any other static methods or fields that are in scope. However, they cannot access instance-specific data or methods of the extended type, since they are not part of the instance itself.
    //    //Question5:
    //    //a)A partial class is a class that can be split into multiple files, allowing different parts of the class to be defined in separate files. This can be useful for organizing large classes or for separating auto-generated code from manually written code. Partial classes are defined using the "partial" keyword in each file, and the compiler combines them into a single class at compile time. All parts of a partial class must have the same access modifier and namespace, and they can contain methods, properties, fields, and other members just like a regular class.
    //    //b)A developer would split a class into multiple files for several reasons, including: code organization, collaboration, code generation, and testing. By splitting a class into multiple files, developers can keep related code together, work on different parts of the class simultaneously, separate auto-generated code from manually written code, and test individual parts of the class in isolation.
    //    //c)A partial method is a method that can be defined in multiple parts across different files, similar to a partial class. It allows developers to split the implementation of a method into separate files, which can be useful for organizing large methods or for separating auto-generated code from manually written code. Partial methods are defined using the "partial" keyword in each file, and the compiler combines them into a single method at compile time. All parts of a partial method must have the same access modifier and return type, and they can contain parameters and other method members just like a regular method.
    //    //d) If a declared partial method has no implementation in any of the partial class files, the compiler will remove the method declaration and any calls to it from the compiled code. This means that the method will not be included in the final assembly, and any code that calls it will be removed as well. This can be useful for creating optional functionality that can be implemented in some parts of a partial class but not in others, without causing compilation errors or runtime exceptions.

    //    #endregion

    //    #region Part2: Practical Questions

    //    #region DeliveryAdress Class
    //    public class DeliveryAddress
    //        {
    //            public string City { get; set; }
    //            public string Street { get; set; }
    //            public int BuildingNumber { get; set; }

    //            public DeliveryAddress(string city, string street, int buildingNumber)
    //            {
    //                City = city;
    //                Street = street;
    //                BuildingNumber = buildingNumber;
    //            }

    //            public DeliveryAddress(string street)
    //            {
    //                Street = street;
    //                City = "New York";
    //                BuildingNumber = 1;
    //            }

    //            public string GetFullAddress()
    //            {
    //                return $"{BuildingNumber} {Street} ,{City}";
    //            }
    //        }
    //        #endregion

    //        #region Shipment Class (Parent Class)
    //        //Shipment Class(Parent Class)


    //    #endregion

    //    #region Standard Shipment Class(Child Class)
    //    //Standard Shipment Class(Child Class)
    //    public class StandardShipment : Shipment, ITrackable, IInsurable
    //        {
    //            //Chaining Constructor
    //            public StandardShipment(string TrackingCode, string Description, int Weight, decimal DeliveryFee) : base(TrackingCode, Description, Weight, DeliveryFee)
    //            {
    //                  TotalShipmentsCreated++;
    //            }
    //            //Print Shipment Override method
    //            public override string PrintShipmentDetails()
    //            {
    //                return "Standard Shipment\n\n" + base.PrintShipmentDetails() + $"Description: {Description}\n" + $"Estimated Cost: {EstimatedCost}\n";
    //            }
    //            //ITrackable Implementation
    //            public string GetTrackingStatus()
    //            {
    //                return $"Tracking Status\nShipment {TrackingCode} is Ready.\n";
    //            }
    //            //IInsurable Implementation
    //            public decimal CalculateInsurance()
    //            {
    //                return EstimatedCost * 0.05m;
    //            }
    //        }
    //        #endregion

    //        #region Express Shipment Class(Child Class)
    //        //Express Shipment Class(Child Class)
    //        public class ExpressShipment : Shipment, ITrackable, IInsurable
    //        {
    //            decimal extrafee;
    //            //ExtraFee Property
    //            public decimal ExtraFee
    //            {
    //                get
    //                {
    //                    return extrafee;
    //                }
    //                set
    //                {
    //                    if (value < 0)
    //                        throw new ArgumentException("Extra fee must be greater than or equal to 0");
    //                    else
    //                        extrafee = value;
    //                }
    //            }
    //            //Override Estimated cost property
    //            public override decimal EstimatedCost
    //            {
    //                get
    //                {
    //                    return base.EstimatedCost + extrafee;
    //                }

    //            }
    //            //Print Shipment Override method
    //            public override string PrintShipmentDetails()
    //            {
    //                return "Express Shipment\n\n" + base.PrintShipmentDetails() + $"Extra Fee: {extrafee}\n" + $"Estimated Cost: {EstimatedCost}";
    //            }
    //            public ExpressShipment(string TrackingCode, string Description, int Weight, decimal DeliveryFee, decimal extrafee) : base(TrackingCode, Description, Weight, DeliveryFee)
    //            {
    //                this.ExtraFee = extrafee;
    //                TotalShipmentsCreated++;
    //            }
    //            //ITrackable Implementation
    //            public string GetTrackingStatus()
    //            {
    //                return $"Shipment {TrackingCode} is Out for Delivery.\n";
    //            }
    //            //IInsurable Implementation
    //            public decimal CalculateInsurance()
    //            {
    //                return EstimatedCost * 0.08m;
    //            }
    //        }
    //        #endregion

    //        #region International Shipment Class(Child Class) 
    //        //International Shipment Class(parent class)
    //        public class InternationalShipment : Shipment, ITrackable, IInsurable
    //        {
    //            string destinationcountry;
    //            decimal customsfee;
    //            //Destination Country property
    //            public string DestinationCountry
    //            {
    //                get
    //                {
    //                    return destinationcountry;
    //                }
    //                set
    //                {
    //                    if (string.IsNullOrWhiteSpace(value))
    //                    {
    //                        throw new ArgumentException("Description cannot be null or empty.");
    //                    }
    //                    else
    //                    {
    //                        destinationcountry = value;
    //                    }


    //                }
    //            }
    //            //Customs Fee property
    //            public decimal CustomsFee
    //            {
    //                get
    //                {
    //                    return customsfee;
    //                }
    //                set
    //                {
    //                    if (value < 0)
    //                        throw new ArgumentException("Extra fee must be greater than or equal to 0");
    //                    else
    //                        customsfee = value;
    //                }
    //            }
    //            //Override Estimated cost property
    //            public override decimal EstimatedCost
    //            {
    //                get
    //                {
    //                    return base.EstimatedCost + customsfee;
    //                }

    //            }
    //            //Print Shipment Override method
    //            public override string PrintShipmentDetails()
    //            {
    //                return "International Shipment\n\n" + base.PrintShipmentDetails() + $"Destination: {destinationcountry}\n" + $"Estimated Cost: {EstimatedCost}";
    //            }
    //            //Constructor chaining
    //            public InternationalShipment(string TrackingCode, string Description, int Weight, decimal DeliveryFee, decimal customsfee, string destinationcountry) : base(TrackingCode, Description, Weight, DeliveryFee)
    //            {
    //                this.CustomsFee = customsfee;
    //                this.DestinationCountry = destinationcountry;
    //                TotalShipmentsCreated++;
    //            }
    //            //ITrackable Implementation
    //            public string GetTrackingStatus()
    //            {
    //                return $"Shipment {TrackingCode} has been delivered.";
    //            }
    //            //IInsurable Implementation
    //            public decimal CalculateInsurance()
    //            {
    //                return EstimatedCost * 0.12m;
    //            }
    //        }
    //        #endregion

    //        #region Delivery Center Class
    //        //Delivery Center Class
    //        public class DeliveryCenter
    //        {
    //            public string CenterName;
    //            public string AssignedDriver;
    //            Shipment[] shipment;
    //            public DeliveryCenter()
    //            {
    //                shipment = new Shipment[20];
    //            }
    //            //Integer Indexer
    //            public Shipment this[int index]
    //            {
    //                get
    //                {
    //                    if (index >= 0 && index < shipment.Length)
    //                    {
    //                        return shipment[index];
    //                    }
    //                    return default;
    //                }
    //                set
    //                {
    //                    if (index >= 0 && index < shipment.Length)
    //                    {
    //                        shipment[index] = value;
    //                    }
    //                }
    //            }
    //            //String Indexer
    //            public Shipment this[string trackingcode]
    //            {
    //                get
    //                {
    //                    for (int i = 0; i < shipment.Length; i++)
    //                    {
    //                        if (shipment[i] != null &&
    //                            shipment[i].TrackingCode == trackingcode)
    //                        {
    //                            return shipment[i];
    //                        }
    //                    }

    //                    return null;
    //                }
    //            }
    //            //AddShipment Method
    //            public bool AddShipment(Shipment newshipment)
    //            {
    //                for (int i = 0; i < shipment.Length; i++)
    //                {
    //                    if (shipment[i] == null)
    //                    {
    //                        shipment[i] = newshipment;
    //                        return true;
    //                    }
    //                }

    //                return false;
    //            }
    //            //RemoveShipment Method
    //            public bool RemoveShipment(string trackingcode)
    //            {
    //                for (int i = 0; i < shipment.Length; i++)
    //                {
    //                    if (shipment[i].TrackingCode != null && shipment[i].TrackingCode == trackingcode)
    //                    {
    //                        shipment[i] = null;
    //                        return true;
    //                    }
    //                }
    //                return false;
    //            }
    //            //Print all shipments method
    //            public void PrintAllShipments()
    //            {
    //                foreach (Shipment s in shipment)
    //                {
    //                    if (s != null)
    //                    {
    //                        Console.WriteLine(s.PrintShipmentDetails());
    //                    }
    //                }
    //            }
    //            //PrintShipment(ITrackable shipment)
    //            public void PrintShipment(ITrackable shipment)
    //            {
    //                if (shipment != null)
    //                {
    //                    Console.WriteLine(shipment.GetTrackingStatus());
    //                }
    //            }
    //            //PrintShipment(IInsurable shipment)
    //            public void PrintShipment(IInsurable shipment)
    //            {
    //                if (shipment != null)
    //                {
    //                    Console.WriteLine($"Insurance\n {shipment.GetType().Name}: {shipment.CalculateInsurance()}");
    //                }
    //            }
    //            public void PrintTrackingStatuses()
    //            {

    //                foreach (ITrackable t in shipment)
    //                {
    //                    if (t != null)
    //                    {
    //                        t.GetTrackingStatus();
    //                    }
    //                }
    //            }
    //            public void PrintInsuranceCosts()
    //            {
    //                foreach (IInsurable i in shipment)
    //                {
    //                    if (i != null)
    //                    {
    //                        i.CalculateInsurance();
    //                    }
    //                }
    //            }

    //        }
    //        #endregion

    //        #region Delivery Helper Class
    //        public static class DeliveryHelper
    //        {
    //            public static void PrintShipmentDetails(Shipment shipment)
    //            {
    //                if (shipment != null)
    //                    Console.WriteLine(shipment.PrintShipmentDetails());
    //            }
    //        }
    //        #endregion

    //        #region Driver Class
    //        public class Driver
    //        {
    //            public string name
    //            {
    //                get;
    //                set
    //                {
    //                    if (value is null || value is "")
    //                        throw new ArgumentException("Please enter a valid driver's name");
    //                }
    //            }

    //            public Driver(string name)
    //            {
    //                this.name = name;
    //        }

    //    }
    //    #endregion

    //        #region Delivery Utilities Class
    //    public static class DeliveryUtilities
    //    { 
    //    public static void PrintSeparator() => Console.WriteLine(new string('-', 40));

    //    public static void PrintSystemTitle() => Console.WriteLine("Delivery Center ");

    //    }
    //    #endregion
    //    #region Shipment Extensions Class
    //    public static class ShipmentExtensions
    //    {
    //        public static string GetSummary(this Shipment shipment)
    //        {
    //            if (shipment == null) return "Null Shipment";

    //            // Check if the shipment implements ITrackable to safely get its status
    //            string status = shipment is ITrackable trackable
    //                ? trackable.GetTrackingStatus()
    //                : "No Tracking Available";

    //            return $"{shipment.TrackingCode} | {shipment.GetType().Name} | {shipment.Weight} KG | {status}";
    //        }
    //        public static bool IsDelivered(this Shipment shipment)
    //        {
    //            if(shipment is ITrackable trackable)
    //            {
    //                if(trackable.GetTrackingStatus() != null && trackable.GetTrackingStatus().Contains("delivered"))
    //                {
    //                    return true;
    //                }

    //            }
    //           return false;
    //        }
    //    }
    //    #endregion
    //    #region Main
    //    internal class Program
    //        {
    //            static void Main(string[] args)
    //            {
    //            ////a.Create a Driver
    //            //Console.WriteLine("Enter Driver Name:");
    //            //string driverName = Console.ReadLine();

    //            //Driver driver = new Driver(driverName);
    //            //// b. Create a DeliveryCenter
    //            //Console.WriteLine("Enter Delivery Center Name:");
    //            //string centerName = Console.ReadLine();

    //            //DeliveryCenter center = new DeliveryCenter();
    //            //center.CenterName = centerName;

    //            ////c.Assign driver to delivery center
    //            //center.AssignedDriver = driver.name;
    //            // a. Create Standard Shipment
    //            //StandardShipment standardShipment =
    //            //    new StandardShipment(
    //            //        "SH001",
    //            //        "Laptop",
    //            //        2,
    //            //        100.0m
    //            //    );

    //            //// b. Create Express Shipment
    //            //ExpressShipment expressShipment =
    //            //   new ExpressShipment(
    //            //     "SH002",
    //            //     "Laptop",
    //            //     2,
    //            //     100.0m,
    //            //     30.0m
    //            //   );
    //            //// c. Create International Shipment
    //            //InternationalShipment internationalShipment =
    //            //    new InternationalShipment(
    //            //      "SH003",
    //            //      "Laptop",
    //            //       2,
    //            //       100.0m,
    //            //       30.0m,
    //            //      "Germany"
    //            //    );

    //            //// d. Add shipments to Delivery Center
    //            //DeliveryCenter center = new DeliveryCenter();
    //            //center.AddShipment(standardShipment);
    //            //center.AddShipment(expressShipment);
    //            //center.AddShipment(internationalShipment);
    //            ////e. Print all shiipment details
    //            //for (int i = 0; i < 20; i++)
    //            //{
    //            //    if (center[i] != null)
    //            //    {
    //            //        DeliveryHelper.PrintShipmentDetails(center[i]);
    //            //        Console.WriteLine("------------------------------------");
    //            //    }
    //            //}
    //            ////f. Print tracking status for each shipment
    //            //for (int i = 0; i < 20; i++)
    //            //{
    //            //    if (center[i] != null)
    //            //    {
    //            //        center.PrintShipment(center[i] as ITrackable);

    //            //    }
    //            //}
    //            ////f. Print tracking status for each shipment
    //            //for (int i = 0; i < 20; i++)
    //            //{
    //            //    if (center[i] != null)
    //            //    {
    //            //        center.PrintShipment(center[i] as IInsurable);

    //            //    }
    //            //}
    //            //ITrackable[] trackableShipments = new ITrackable[] { standardShipment, expressShipment, internationalShipment };
    //            //for (int i = 0; i < trackableShipments.Length; i++)
    //            //{
    //            //    if (trackableShipments[i] != null)
    //            //    {

    //            //        Console.WriteLine(trackableShipments[i].GetTrackingStatus());
    //            //    }
    //            //}
    //            //IInsurable[] insurableShipments = new IInsurable[] { standardShipment, expressShipment, internationalShipment };
    //            //for (int i = 0; i < insurableShipments.Length; i++)
    //            //{
    //            //    if (insurableShipments[i] != null)
    //            //    {
    //            //        Console.WriteLine(insurableShipments[i].CalculateInsurance());

    //            //    }
    //            //}



    //            //// h & i. Print all shipments 
    //            //Console.WriteLine("------------------------------------");
    //            //Console.WriteLine($"Delivery Center: {center.CenterName}");
    //            //Console.WriteLine("------------------------------------");
    //            //Console.WriteLine($"\nDriver Name: {driver.name}");
    //            //Console.WriteLine("------------------------------------");
    //            //center.PrintAllShipments();

    //            ////j. demonstrate both versions of update weight
    //            //int updatedWeight = 5;
    //            //standardShipment.UpdateDeilveryFee(20.5m);
    //            //Console.WriteLine("------------------------------------");
    //            //Console.WriteLine($"Original Weight : {expressShipment.Weight} KG");
    //            //expressShipment.Weight = updatedWeight;
    //            //expressShipment.UpdateDeilveryFee(50.0m, updatedWeight);
    //            //Console.WriteLine($"Updated Weight : {expressShipment.Weight} KG");
    //            //Console.WriteLine($"Updated Weight after Packing : {expressShipment.Weight + 0.5} KG");

    //            //k. Build a Shipment[] holding mixed types and print all of them in a loop.
    //            //    Shipment[] mixedShipments = new Shipment[]
    //            //{
    //            //new StandardShipment("STD-101", "Textbooks", 3, 45.0m),
    //            //new ExpressShipment("EXP-202", "Smartphone", 1, 80.0m, 25.0m),
    //            //new InternationalShipment("INT-303", "Machine Parts", 12, 200.0m, 75.0m, "Canada")
    //            //};
    //            //    Console.WriteLine("========== MIXED SHIPMENTS ==========");
    //            //    foreach (Shipment s in mixedShipments)
    //            //    {
    //            //        if (s != null)
    //            //        {
    //            //            Console.WriteLine(s.PrintShipmentDetails());
    //            //            Console.WriteLine("------------------------------------------");
    //            //        }
    //            //    }

    //            //// 7. Search using the tracking-code indexer
    //            //Console.WriteLine("\nEnter Tracking Code to Search:");
    //            //string searchCode = Console.ReadLine();

    //            //Shipment foundShipment = center[searchCode];

    //            //if (foundShipment != null)
    //            //{
    //            //    Console.WriteLine("\nShipment Found:");
    //            //    Console.WriteLine(foundShipment.PrintShipmentDetails());
    //            //}
    //            //else
    //            //{
    //            //    Console.WriteLine("No Shipment Found!!");
    //            //}


    //            //// 8. Remove shipment
    //            //Console.WriteLine("\nEnter Tracking Code to Remove:");
    //            //string removeCode = Console.ReadLine();

    //            //bool removed = center.RemoveShipment(removeCode);

    //            //if (removed)
    //            //{
    //            //    Console.WriteLine("Shipment Removed Successfully.");
    //            //}
    //            //else
    //            //{
    //            //    Console.WriteLine("Shipment Not Found.");
    //            //}


    //            //// 9. Print remaining shipments
    //            //Console.WriteLine("\n========== REMAINING SHIPMENTS ==========");
    //            //center.PrintAllShipments();
    //            //Shipment shipment1 = new StandardShipment("STD-001", "Books", 2, 50.0m);
    //            ////create a copy of the shipment using the CopyShipment method
    //            //Shipment shipment2 = shipment1.CopyShipment();
    //            //Console.WriteLine($"Original Shipment: {shipment1.PrintShipmentDetails()}");
    //            //Console.WriteLine($"Copied Shipment: {shipment2.PrintShipmentDetails()}");
    //            //shipment2.TrackingCode = "STD-002";
    //            //Console.WriteLine($"After changing the tracking code of the copied shipment: {shipment2.TrackingCode}");
    //            //Console.WriteLine($"After changing the tracking code of the copied shipment: {shipment1.TrackingCode}");


    //            //Shipment shipment1 = new StandardShipment("STD-001", "Books", 2, 50.0m);
    //            //shipment1.Destination = new DeliveryAddress("Los Angeles", "Sunset Blvd", 123);
    //            ////create a shallow copy of the shipment using the ShallowCopy method
    //            //Shipment shipment2 = shipment1.ShallowCopy();
    //            //Console.WriteLine(ReferenceEquals(shipment1, shipment2)); // Output: False
    //            //Console.WriteLine(ReferenceEquals(shipment1.Destination, shipment2.Destination)); // Output: True
    //            //Console.WriteLine($"Original Shipment Destination: {shipment1.Destination.GetFullAddress()}");
    //            //Console.WriteLine($"Copied Shipment Destination: {shipment2.Destination.GetFullAddress()}");
    //            //shipment2.Destination.City = "San Francisco";
    //            //shipment2.Destination.BuildingNumber = 456;
    //            //shipment2.Destination.Street = "Market St";
    //            //Console.WriteLine($"Origin Shipment Destination: {shipment1.Destination.GetFullAddress()}");
    //            //Console.WriteLine($"Copied Shipment Destination: {shipment2.Destination.GetFullAddress()}");//Both shipments share the same destination object, so changes made to the destination of one shipment will affect the other shipment's destination as well.

    //            //Shipment shipment1 = new StandardShipment("STD-001", "Books", 2, 50.0m);
    //            //shipment1.Destination = new DeliveryAddress("Cairo");
    //            //Shipment shipment2 = shipment1.DeepCopy();
    //            //Console.WriteLine($"Before Change.....\nOriginal Shipment Destination: {shipment1.Destination.GetFullAddress()}\n Copied Shipment Destination: {shipment2.Destination.GetFullAddress()}");
    //            //Console.WriteLine(ReferenceEquals(shipment1, shipment2)); // Output: False
    //            //Console.WriteLine(ReferenceEquals(shipment1.Destination, shipment2.Destination)); // Output: False
    //            //shipment2.Destination = new DeliveryAddress("Giza");
    //            //Console.WriteLine($"After Change.....\nOriginal Shipment Destination: {shipment1.Destination.GetFullAddress()}\n Copied Shipment Destination: {shipment2.Destination.GetFullAddress()}");
    //            //Console.WriteLine(ReferenceEquals(shipment1.Destination, shipment2.Destination)); // Output: False


    //                // 1. Use DeliveryUtilities
    //                DeliveryUtilities.PrintSystemTitle();
    //                DeliveryUtilities.PrintSeparator();

    //                // 2. Demonstrate Static Constructor & Static Counter before any object is created
    //                Console.WriteLine($"Total Shipments Initial Value: {Shipment.GetTotalShipmentsCreated()}");
    //                DeliveryUtilities.PrintSeparator();

    //                // 3. Create Shipments (Demonstrates partial method logging on creation)
    //                StandardShipment std = new StandardShipment("STD-101", "Textbooks", 3, 45.0m);
    //                ExpressShipment exp = new ExpressShipment("EXP-202", "Smartphone", 1, 80.0m, 25.0m);
    //                InternationalShipment intel = new InternationalShipment("INT-303", "Machine Parts", 12, 200.0m, 75.0m, "Germany");

    //                DeliveryUtilities.PrintSeparator();

    //                // 4. Call GetTotalShipmentsCreated() after object creation
    //                Console.WriteLine($"Total Shipments Created (via Static Method): {Shipment.GetTotalShipmentsCreated()}");
    //                DeliveryUtilities.PrintSeparator();

    //                // 5. Demonstrate GetSummary() Extension Method
    //                Console.WriteLine("--- Extension Method: GetSummary() ---");
    //                Console.WriteLine(std.GetSummary());
    //                Console.WriteLine(exp.GetSummary());
    //                Console.WriteLine(intel.GetSummary());
    //                DeliveryUtilities.PrintSeparator();

    //                // 6. Demonstrate IsDelivered() Extension Method
    //                Console.WriteLine("--- Extension Method: IsDelivered() ---");
    //                Console.WriteLine($"Is '{std.TrackingCode}' delivered? -> {std.IsDelivered()}");
    //                Console.WriteLine($"Is '{intel.TrackingCode}' delivered? -> {intel.IsDelivered()}");

    //                DeliveryUtilities.PrintSeparator();
    //                Console.WriteLine("Program execution completed successfully.");


    //        }
    //        }
    //        #endregion

    //        #endregion
    #region Advanced C# 01 - Questions Answers
    //Q1:A generic class is a class that can work with different data types using a type parameter such as T, without specifying the actual data type when defining the class.
    //We use generics because they provide type safety, code reusability, and performance benefits. Generics allow us to create classes, methods, and data structures that can work with any data type while ensuring that the correct type is used at compile time. This helps to prevent runtime errors and improves code maintainability.
    //Q2
    //Q3:Multiple type parameters means that a generic class can use more than one type parameter, allowing it to work with different data types within the same class.
    class Container<T>
    {
        private T data;

        public void Add(T value)
        {
            data = value;
        }

        public T Get()
        {
            return data;
        }
    }
    class Pair<TKey, TValue>
    {
        public TKey Key;
        public TValue Value;

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Container<int> c1 = new Container<int>();

            c1.Add(100);
            Console.WriteLine(c1.Get());

            Container<string> c2 = new Container<string>();

            c2.Add("Hello");
            Console.WriteLine(c2.Get());
            Pair<int, string> p1 = new Pair<int, string>(1, "Ahmed");

            Console.WriteLine(p1.Key);   // 1
            Console.WriteLine(p1.Value); // Ahmed
        }
    #endregion

    }
}
