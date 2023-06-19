using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    //__________________________________________________ Single responsibility Principle
   
    /*
  enum SubscriptionTypes {
  BASIC = 'BASIC',
  PREMIUM = 'PREMIUM'
}
 
class User {
  constructor (
    public readonly firstName: string,
    public readonly lastName: string,
    public readonly email: string,
    public readonly subscriptionType: SubscriptionTypes,
    public readonly subscriptionExpirationDate: Date
  ) {}
 
  public get name(): string {
    return `${this.firstName} ${this.lastName}`;
  }
 
  public hasUnlimitedContentAccess() {
    const now = new Date();
 
    return this.subscriptionType === SubscriptionTypes.PREMIUM
      && this.subscriptionExpirationDate > now;
  }
}*/
}
//__________________________________________________ Open Close Principle
/*
 class Rect {
  constructor(
    public readonly width: number,
    public readonly height: number
  ) { }
}
 
class Square {
  constructor(
    public readonly width: number
  ) { }
}
 
class Circle {
  constructor(
    public readonly r: number
  ) { }
}
 
class ShapeManager {
  public static getMinArea(shapes: (Rect | Square | Circle)[]): number {
    const areas = shapes.map(shape => {
      if (shape instanceof Rect) {
        return shape.width * shape.height;
      }
 
      if (shape instanceof Square) {
        return Math.pow(shape.width, 2);
      }
 
      if (shape instanceof Circle) {
        return Math.PI * Math.pow(shape.r, 2);
      }
 
      throw new Error('Is not implemented');
    });
 
    return Math.min(...areas);
  }
}
 */
//__________________________________________________ Liskov Substitution Principle
/*
class Vehicle {
  accelerate() {
    // implementation
  }
 
  slowDown() {
    // implementation
  }
 
  turn(angle: number) {
    // implementation
  }
}
 
class Car extends Vehicle {
}
 
class Bus extends Vehicle {
}
class Train extends Vehicle {
  turn(angle: number) {
    // is that possible?
  }
}
 */
//__________________________________________________ Interface Segregation Principle
/*
 * interface IDataSource {
  connect(): Promise<boolean>;
  read(): Promise<string>;
}
 
class DbSource implements IDataSource {
  connect(): Promise<boolean> {
    // implementation
  }
 
  read(): Promise<string> {
    // implementation
  }
}
 
class FileSource implements IDataSource {
  connect(): Promise<boolean> {
    // implementation
  }
 
  read(): Promise<string> {
    // implementation
  }
}
 */
//__________________________________________________ Dependency Inversion Principle
/*
public class Order
{
 private readonly Database database;
 public Order(Database database)
 {
 this.database = database;
 }
 public void SaveOrder()
 {
 database.Save(this);
 }
}
public class Database
{
 public void Save(Order order)
 {
 // код для збереження замовлення в базі даних
 }
}
 */
