using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MockOrderService.DataMembers;
using System.Xml.Serialization;
using System.IO;

namespace MockOrderService.Repository
{
    public class CreateXML
    {
        public void CreateXMLFile()
        {
            //List<Order> orders = CreateObject();
           // XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            //serializer.Serialize(File.Create("D:\\file2.xml"), orders);
        }

        //public List<Order> CreateObject()
        //{
        //    List<Order> orders = new List<Order>()
        //    {
        //        new Order{
        //                CustomerOrderId = 267375,
        //                CustomerOrderReference = "1321935585",
        //                ShortOrderNumber = 44,
        //                WindowStart = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                WindowEnd = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                GridReference = "123",
        //                ScheduledArrival = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                AmbientTrayCount = 2,
        //                ChilledTrayCount = 1,
        //                FrozenTrayCount = 1,
        //                WineTrayCount = 1,
        //                DirectParcelCount = 1,
        //                Customer = new Customer {
        //                    CustomerTitle = "Mr.",
        //                    CustomerSurname ="Gałkowska",
        //                    Address ="1 Falcon Way	AL7 1TW	Welwyn Garden City",
        //                    Postcode ="609973",
        //                    PhoneDaytime ="501395385",
        //                    PhoneEvening = "501395385",
        //                    PhoneMobile = "501395385",
        //                    CustomerFullName ="Nicole Gałkowska",
        //                    SignaturePoints = new int[2],
        //                    customerCommunication = new CustomerCommunication{
        //                         ID = 123,
        //                         CommunicationTime = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                         CommunicationDetail = " Details"
        //                    }
        //                },
        //               DeliveryNotes ="Chwaszczyno- na Szemud - Kielno- ok. 4 km za Kielnem  w prawo ,,Bieszkówko 1 km''  w drogę gruntową, na skrzyż będzie kierun,,Kwiatowa, tłumaczenia'' - tam skręcić w prawo, trzeci dom",
        //               DeliverySlot = "5",
        //               DeliveryWithoutBags = false,
        //               Orderlines = new List<OrderLines>(){
        //                   new OrderLines{
        //                        OrderLineId = 7690880,
        //                        Barcode = "9873242343456",
        //                        Description = "Tesco Kurczak Filet z piersi kurczaka tacka duża",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        RejectionReason =  RejectionReason.Brocken ,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690881,
        //                        Barcode = "9873242343455",
        //                        Description = "Biohumus forte Nawóz do wszelkich roślin w domu na balkonie i tarasie 750 ml",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690882,
        //                        Barcode = "9873242343454",
        //                        Description = "Tesco Jabłka Gloster 2 kg",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690883,
        //                        Barcode = "9873242343453",
        //                        Description = "Bułka włoska 45 g",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "8",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690884,
        //                        Barcode = "9873242343452",
        //                        Description = "Tesco Kurczak Filet z piersi kurczaka tacka duża",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690885,
        //                        Barcode = "9873242343451",
        //                        Description = "Lajkonik Paluszki 300 g",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690886,
        //                        Barcode = "9873242343450",
        //                        Description = "Delecta Salsa Dip łagodny pomidorowy 260 g",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690887,
        //                        Barcode = "9873242343457",
        //                        Description = "Kubuś play! marchew malina Napój wieloowocowo-marchwiowy 400 ml",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "8",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   }
        //               },
        //               CustomerDeliveryStatus = false,
        //               DropSequence = 7,
        //               DropTime = DateTime.Parse("2013-04-18 15:30:00.000"),
        //               TotalItems = 51,
        //               SubTotalAmount = 237.05000,
        //               Discounts = 4.98000,
        //               TotalSubstitutedItems = 0,
        //               TotalOffsaledItems = 0,
        //               StoreMessage = "Store message demo"
        //        },
        //        new Order{
        //                CustomerOrderId = 267376,
        //                CustomerOrderReference = "1321936324",
        //                ShortOrderNumber = 42,
        //                WindowStart = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                WindowEnd = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                GridReference = "123",
        //                ScheduledArrival = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                AmbientTrayCount = 2,
        //                ChilledTrayCount = 1,
        //                FrozenTrayCount = 1,
        //                WineTrayCount = 1,
        //                DirectParcelCount = 1,
        //                Customer = new Customer {
        //                    CustomerTitle = "Mr.",
        //                    CustomerSurname ="Austin",
        //                    Address ="1 Falcon Way	AL7 1TW	Welwyn Garden City",
        //                    Postcode ="609973",
        //                    PhoneDaytime ="501395385",
        //                    PhoneEvening = "501395385",
        //                    PhoneMobile = "501395385",
        //                    CustomerFullName ="Niel Austin",
        //                    SignaturePoints = new int[2],
        //                    customerCommunication = new CustomerCommunication{
        //                         ID = 123,
        //                         CommunicationTime = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                         CommunicationDetail = " Details"
        //                    }
        //                },
        //               DeliveryNotes ="Chwaszczyno- na Szemud - Kielno- ok. 4 km za Kielnem  w prawo ,,Bieszkówko 1 km''  w drogę gruntową, na skrzyż będzie kierun,,Kwiatowa, tłumaczenia'' - tam skręcić w prawo, trzeci dom",
        //               DeliverySlot = "5",
        //               DeliveryWithoutBags = false,
        //               Orderlines = new List<OrderLines>(){
        //                   new OrderLines{
        //                        OrderLineId = 7690880,
        //                        Barcode = "9873242343456",
        //                        Description = "Tesco Kurczak Filet z piersi kurczaka tacka duża",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        RejectionReason =  RejectionReason.Brocken ,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690881,
        //                        Barcode = "9873242343455",
        //                        Description = "Biohumus forte Nawóz do wszelkich roślin w domu na balkonie i tarasie 750 ml",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690882,
        //                        Barcode = "9873242343454",
        //                        Description = "Tesco Jabłka Gloster 2 kg",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690883,
        //                        Barcode = "9873242343453",
        //                        Description = "Bułka włoska 45 g",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "8",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690884,
        //                        Barcode = "9873242343452",
        //                        Description = "Tesco Kurczak Filet z piersi kurczaka tacka duża",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690885,
        //                        Barcode = "9873242343451",
        //                        Description = "Lajkonik Paluszki 300 g",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690886,
        //                        Barcode = "9873242343450",
        //                        Description = "Delecta Salsa Dip łagodny pomidorowy 260 g",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690887,
        //                        Barcode = "9873242343457",
        //                        Description = "Kubuś play! marchew malina Napój wieloowocowo-marchwiowy 400 ml",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "8",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   }
        //               },
        //               CustomerDeliveryStatus = false,
        //               DropSequence = 7,
        //               DropTime = DateTime.Parse("2013-04-18 15:30:00.000"),
        //               TotalItems = 51,
        //               SubTotalAmount = 237.05000,
        //               Discounts = 4.98000,
        //               TotalSubstitutedItems = 0,
        //               TotalOffsaledItems = 0,
        //               StoreMessage = "Store message demo"
        //        },
        //        new Order{
        //                CustomerOrderId = 267377,
        //                 CustomerOrderReference = "1321936265",
        //                ShortOrderNumber = 41,
        //                WindowStart = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                WindowEnd = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                GridReference = "123",
        //                ScheduledArrival = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                AmbientTrayCount = 2,
        //                ChilledTrayCount = 1,
        //                FrozenTrayCount = 1,
        //                WineTrayCount = 1,
        //                DirectParcelCount = 1,
        //                Customer = new Customer {
        //                    CustomerTitle = "Mr.",
        //                    CustomerSurname ="Aldrin",
        //                    Address ="1 Falcon Way	AL7 1TW	Welwyn Garden City",
        //                    Postcode ="609973",
        //                    PhoneDaytime ="501395385",
        //                    PhoneEvening = "501395385",
        //                    PhoneMobile = "501395385",
        //                    CustomerFullName ="Buzz",
        //                    SignaturePoints = new int[2],
        //                    customerCommunication = new CustomerCommunication{
        //                         ID = 123,
        //                         CommunicationTime = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                         CommunicationDetail = " Details"
        //                    }
        //                },
        //               DeliveryNotes ="Chwaszczyno- na Szemud - Kielno- ok. 4 km za Kielnem  w prawo ,,Bieszkówko 1 km''  w drogę gruntową, na skrzyż będzie kierun,,Kwiatowa, tłumaczenia'' - tam skręcić w prawo, trzeci dom",
        //               DeliverySlot = "5",
        //               DeliveryWithoutBags = false,
        //               Orderlines = new List<OrderLines>(){
        //                   new OrderLines{
        //                        OrderLineId = 7690880,
        //                        Barcode = "9873242343456",
        //                        Description = "Tesco Kurczak Filet z piersi kurczaka tacka duża",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        RejectionReason =  RejectionReason.Brocken ,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690881,
        //                        Barcode = "9873242343455",
        //                        Description = "Biohumus forte Nawóz do wszelkich roślin w domu na balkonie i tarasie 750 ml",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690882,
        //                        Barcode = "9873242343454",
        //                        Description = "Tesco Jabłka Gloster 2 kg",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690883,
        //                        Barcode = "9873242343453",
        //                        Description = "Bułka włoska 45 g",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "8",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690884,
        //                        Barcode = "9873242343452",
        //                        Description = "Tesco Kurczak Filet z piersi kurczaka tacka duża",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690885,
        //                        Barcode = "9873242343451",
        //                        Description = "Lajkonik Paluszki 300 g",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690886,
        //                        Barcode = "9873242343450",
        //                        Description = "Delecta Salsa Dip łagodny pomidorowy 260 g",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690887,
        //                        Barcode = "9873242343457",
        //                        Description = "Kubuś play! marchew malina Napój wieloowocowo-marchwiowy 400 ml",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "8",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   }
        //               },
        //               CustomerDeliveryStatus = false,
        //               DropSequence = 7,
        //               DropTime = DateTime.Parse("2013-04-18 15:30:00.000"),
        //               TotalItems = 51,
        //               SubTotalAmount = 237.05000,
        //               Discounts = 4.98000,
        //               TotalSubstitutedItems = 0,
        //               TotalOffsaledItems = 0,
        //               StoreMessage = "Store message demo"
        //        },
        //        new Order{
        //                CustomerOrderId = 267604,
        //                CustomerOrderReference = "1321935519",
        //                ShortOrderNumber = 40,
        //                WindowStart = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                WindowEnd = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                GridReference = "123",
        //                ScheduledArrival = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                AmbientTrayCount = 2,
        //                ChilledTrayCount = 1,
        //                FrozenTrayCount = 1,
        //                WineTrayCount = 1,
        //                DirectParcelCount = 1,
        //                Customer = new Customer {
        //                    CustomerTitle = "Mr.",
        //                    CustomerSurname ="Smith",
        //                    Address ="1 Falcon Way	AL7 1TW	Welwyn Garden City",
        //                    Postcode ="609973",
        //                    PhoneDaytime ="501395385",
        //                    PhoneEvening = "501395385",
        //                    PhoneMobile = "501395385",
        //                    CustomerFullName ="Deric Smith",
        //                    SignaturePoints = new int[2],
        //                    customerCommunication = new CustomerCommunication{
        //                         ID = 123,
        //                         CommunicationTime = DateTime.Parse("2013-04-18 06:13:00.000"),
        //                         CommunicationDetail = " Details"
        //                    }
        //                },
        //               DeliveryNotes ="Chwaszczyno- na Szemud - Kielno- ok. 4 km za Kielnem  w prawo ,,Bieszkówko 1 km''  w drogę gruntową, na skrzyż będzie kierun,,Kwiatowa, tłumaczenia'' - tam skręcić w prawo, trzeci dom",
        //               DeliverySlot = "5",
        //               DeliveryWithoutBags = false,
        //               Orderlines = new List<OrderLines>(){
        //                   new OrderLines{
        //                        OrderLineId = 7690880,
        //                        Barcode = "9873242343456",
        //                        Description = "Tesco Kurczak Filet z piersi kurczaka tacka duża",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        RejectionReason =  RejectionReason.Brocken ,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690881,
        //                        Barcode = "9873242343455",
        //                        Description = "Biohumus forte Nawóz do wszelkich roślin w domu na balkonie i tarasie 750 ml",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690882,
        //                        Barcode = "9873242343454",
        //                        Description = "Tesco Jabłka Gloster 2 kg",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690883,
        //                        Barcode = "9873242343453",
        //                        Description = "Bułka włoska 45 g",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "8",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690884,
        //                        Barcode = "9873242343452",
        //                        Description = "Tesco Kurczak Filet z piersi kurczaka tacka duża",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690885,
        //                        Barcode = "9873242343451",
        //                        Description = "Lajkonik Paluszki 300 g",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690886,
        //                        Barcode = "9873242343450",
        //                        Description = "Delecta Salsa Dip łagodny pomidorowy 260 g",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "1",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   },
        //                    new OrderLines{
        //                        OrderLineId = 7690887,
        //                        Barcode = "9873242343457",
        //                        Description = "Kubuś play! marchew malina Napój wieloowocowo-marchwiowy 400 ml",
        //                        IsSubstitued = false,
        //                        PickedQuantity= "8",
        //                        RejectedQuantity = 0,
        //                        SubstitutedFor = "7690883",
        //                        UnitPrice = 18.69000
        //                   }
        //               },
        //               CustomerDeliveryStatus = false,
        //               DropSequence = 7,
        //               DropTime = DateTime.Parse("2013-04-18 15:30:00.000"),
        //               TotalItems = 51,
        //               SubTotalAmount = 237.05000,
        //               Discounts = 4.98000,
        //               TotalSubstitutedItems = 0,
        //               TotalOffsaledItems = 0,
        //               StoreMessage = "Store message demo"
        //        }
        //    };


        //    return orders;
        //}
    }
}