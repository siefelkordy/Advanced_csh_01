using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_csh_01
{
    public partial class Shipment
    {
        string trackingCode;
        string description;
        int weight;
        decimal deliveryFee;
        DeliveryAddress destination;
        public static int TotalShipmentsCreated;


        //Properties
        //1.Tracking Code Property
        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
                else
                {
                    throw new ArgumentException("Tracking Code can't be null or empty");
                }
            }
        }
        //2.Description Property
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Description cannot be null or empty.");
                }
                else
                {
                    description = value;
                }
            }
        }
        //3.Weight Property
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Weight must be a positive number.");
                }
                weight = value;
            }

        }
        //4.Delivery Fee Property
        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Delivery fee must be a positive number.");
                }
                else
                {
                    deliveryFee = value;
                }
            }
        }
        //5.Destination Property
        public DeliveryAddress Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }
        public virtual decimal EstimatedCost
        {
            get
            {
                return deliveryFee + (weight * 5);
            }
        }

        //////////////Constructors
        //1st Constructor
        public Shipment(string trackingCode)
        {
            this.trackingCode = trackingCode;
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            destination = new DeliveryAddress("Nasr city", "Al Nahas", 15);
        }
        //2nd Constructor
        public Shipment(string TrackingCode, string Description, int Weight, decimal DeliveryFee)
        {
            trackingCode = TrackingCode;
            description = Description;
            weight = Weight;
            deliveryFee = DeliveryFee;
        }
        //Static Constructor
        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }
        //////////////Methods
        //Update DeliveryFee Method
        public void UpdateDeilveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee;
            }
            else
            {
                throw new ArgumentException("Delivery fee must be a positive number.");
            }
        }
        public void UpdateDeilveryFee(decimal newFee, int packingWeight)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee + (packingWeight * 5);
            }
            else
            {
                throw new ArgumentException("Delivery fee must be a positive number.");
            }
        }
        //Print Shipment Method
        public virtual string PrintShipmentDetails()
        {
            return $"Tracking Code: {TrackingCode}\n";
        }
        //Copy shipment method
        public Shipment CopyShipment()
        {
            return new Shipment(this.trackingCode, this.description, this.weight, this.deliveryFee);
        }
        //Shallow Copy Method
        public Shipment ShallowCopy()
        {
            TotalShipmentsCreated++;
            return (Shipment)this.MemberwiseClone();
        }
        //Deep Copy Method
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)this.MemberwiseClone();
            copy.Destination = new DeliveryAddress(this.Destination.City, this.Destination.Street, this.Destination.BuildingNumber);
            TotalShipmentsCreated++;
            return copy;
        }
        //Get Total Shipments Created Static Method
        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }
        //Tracking Status Changed Partial Method
        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }
    }
}
