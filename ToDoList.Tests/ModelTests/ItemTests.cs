// using System;
// using System.Collections.Generic;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using ToDoList.Models;
// using MySql.Data.MySqlClient;

// namespace ToDoList.Tests
// {
//   [TestClass]
//   public class ItemTests : IDisposable
//   {
//     public void Dispose()
//     {
//       Item.ClearAll();
//     }

//     public ItemTest()
//     {
//       DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=to_do_list_test;";
//     }


//     [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item()
//     {
//       Item newItem = new Item("test");
//       newItem.Save();
//       Assert.AreEqual(typeof(Item), newItem.GetType());
//     }

//     [TestMethod]
//     public void GetDescription_ReturnsDescription_String()
//     {
//       //Arrange
//       string description = "take out the trash";
//       Item newItem = new Item(description);
//       newItem.Save();
//       //Act
//       string result = newItem.Description;
//       //Assert
//       Assert.AreEqual(description, result);
//     }

//     [TestMethod]
//     public void SetDecription_SetDescription_string()
//     {
//       //Arrange
//       string description = "Walk the dog.";
//       Item newItem = new Item(description);
//       newItem.Save();

//       //Act
//       string updatedDescription = "Do the dishes";
//       newItem.Description = updatedDescription;
//       string result = newItem.Description;

//       //Assert
//       Assert.AreEqual(updatedDescription, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsEmptyListFromDatabase_ItemList()
//     {
//       //Arrange
//       List<Item> newList = new List<Item> { };

//       //Act
//       List<Item> result = Item.GetAll();

//       //Assert
//       CollectionAssert.AreEqual(newList, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsItems_ItemList()
//     {
//       //Arrange
//       string description01 = "Mow the lawn.";
//       string description02 = "Sweep the porch.";
//       Item newItem1 = new Item(description01);
//       newItem1.Save();
//       Item newItem2 = new Item(description02);
//       newItem2.Save();
//       List<Item> newList = new List<Item> {newItem1, newItem2};

//       //Act
//       List<Item> result = Item.GetAll();
//       foreach (Item thisItem in result)
//       {
//         Console.WriteLine("Output from second GetAll test: " + thisItem.Description);
//       }

//       //Assert
//       CollectionAssert.AreEqual(newList, result);
//     }

//     [TestMethod]
//     public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
//     {
//       //Arrange
//       string description = "Walk the dog.";
//       Item newItem = new Item(description);
//       newItem.Save();

//       //Act
//       int result = newItem.Id;

//       //Assert
//       Assert.AreEqual(1, result);
//     }

//     [TestMethod]
//     public void Find_ReturnsCorrectItem_Item()
//     {
//       //Arrange
//       string description01 = "Walk the dog";
//       string description02 = "Wash the dishes";
//       Item newItem1 = new Item(description01);
//       newItem1.Save();
//       Item newItem2 = new Item(description02);
//       newItem2.Save();
//       //Act
//       Item result = Item.Find(2);

//       //Assert
//       Assert.AreEqual(newItem2, result);
//     }

//     [TestMethod]
//     public void Save_SavesToDatabase_ItemList()
//     {
//       //Arrange
//       Item testItem = new Item("Mow the lawn");

//       //Act
//       testItem.Save();
//       List<Item> result = Item.GetAll();
//       List<Item> testList = new List<Item>{testItem};

//       //Assert
//       CollectionAssert.AreEqual(testList, result);
//     }

//   }
// }