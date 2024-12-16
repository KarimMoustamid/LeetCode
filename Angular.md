### <h3 style="background-color: #15803d; color: white;display: inline-block;">npm and node_modules</h3>

#### **npm (Node Package Manager):**

- **npm** is a package manager for JavaScript, commonly used with Node.js.
- It allows developers to install, share, and manage dependencies (libraries, tools, or frameworks) required by their JavaScript applications.
- When you initialize a project with npm using `npm init`, it creates a `package.json` file. This file keeps track of the dependencies used in the project and their metadata.

Some commonly used npm commands:

1. `npm install <package-name>`: Installs a package locally in your project.
2. `npm install`: Installs all the dependencies listed in `package.json`.
3. `npm uninstall <package-name>`: Removes a previously installed package.

#### **node_modules Folder**

- The **node_modules** folder is the directory where npm installs the dependencies for your project.
- When you use `npm install`, npm fetches the packages and their dependencies specified in `package.json` and places them in `node_modules`.

Key points about `node_modules`:

- It contains all the libraries required for your project to work.
- Sub-dependencies (dependencies of a dependency) are also installed here.
- It's usually not committed to version control systems like Git, as the `package.json` is sufficient to regenerate the `node_modules` folder using the `npm install` command.

> **Tip**: To ignore `node_modules` in Git, add it to your `.gitignore` file:
> ```
> node_modules/
> ```

In summary, `npm` is the tool to manage dependencies, and `node_modules` is the directory where those dependencies are stored for your project.

### <h3 style="background-color: #15803d; color: white;display: inline-block;">package.json</h3>

The `package.json` file is a critical configuration file for any Node.js or JavaScript project that uses npm. It provides information about the project and its dependencies, scripts, metadata, and more. Here's a breakdown of its key sections:

#### Key Sections of `package.json`:

1. **Metadata**:  
   Provides general information about the project.
   ```json
   {
     "name": "your-project-name",    // The name of the project (lowercase, no spaces)
     "version": "1.0.0",            // The version of your project
     "description": "Project description", // Brief description of the project
     "main": "index.js",            // The entry point file of the project
     "author": "Author Name",       // Project author
     "license": "ISC"               // License type for the project
   }
   ```

2. **Dependencies**:  
   Lists the libraries or packages that the project depends on to run.  
   They can be installed using the `npm install <package-name>` command.
   ```json
   {
     "dependencies": {
       "express": "^4.17.3",       // Specifies a package and its version range
       "lodash": "~4.17.20"
     }
   }
   ```

- `"^4.17.3"`: Accepts the latest minor or patch releases in the 4.x.x range.
- `"~4.17.20"`: Accepts the latest patch release for 4.17.x.

3. **Dev Dependencies**:  
   Similar to dependencies but for packages only required during development, such as testing libraries or build tools. Installed using `npm install --save-dev <package-name>`.
   ```json
   {
     "devDependencies": {
       "eslint": "^8.18.0",         // Linter for JavaScript
       "karma": "^6.3.0"           // Testing framework
     }
   }
   ```

4. **Scripts**:  
   Defines custom tasks or commands you can run using `npm run`.  
   Example:
   ```json
   {
     "scripts": {
       "start": "node index.js",       // Runs the application
       "build": "webpack",            // Runs a build tool
       "test": "jest"                 // Runs tests
     }
   }
   ```
   To execute a script, run `npm run <script-name>` (e.g., `npm run start`).

5. **Engines**:  
   Specifies the compatible version of Node.js (or other tools).
   ```json
   {
     "engines": {
       "node": ">=14.0.0",
       "npm": ">=6.14.0"
     }
   }
   ```

6. **Peer Dependencies (Optional)**:  
   Indicates a package that your module depends on but does not install automatically. Other developers must install it manually to ensure compatibility.
   ```json
   {
     "peerDependencies": {
       "react": "^18.0.0"
     }
   }
   ```

7. **Other Fields**:

- `"keywords"`: A list of relevant keywords to make the package easier to discover.
- `"repository"`: Provides information about where the source code is hosted.
- `"bugs"`: Issue tracker URL for the project.

#### Example `package.json`:

```json
{
  "name": "my-app",
  "version": "1.0.0",
  "description": "A sample Node.js project",
  "main": "index.js",
  "author": "John Doe",
  "license": "MIT",
  "dependencies": {
    "express": "^4.18.2"
  },
  "devDependencies": {
    "mocha": "^9.2.2"
  },
  "scripts": {
    "start": "node index.js",
    "test": "mocha"
  },
  "engines": {
    "node": ">=14.17.0"
  }
}
```

In summary, the `package.json` serves as the backbone of any JavaScript project, laying out its structure, dependencies, and critical configurations.

### <h3 style="background-color: #1d4ed8; color: white;display: inline-block;">Typescript</h3>

TypeScript is a strongly typed, object-oriented, and compiled programming language that builds on JavaScript. Developed by Microsoft, TypeScript adds static types, interfaces, and modern syntax features, enabling large-scale application development while maintaining compatibility with existing JavaScript code. It enhances tooling and reduces runtime errors by providing compile-time checks.

### <h3 style="background-color: #1d4ed8; color: white; display: inline-block;">Key Concepts in TypeScript</h3>

1. **Types and Type Annotations**  
   TypeScript introduces static typing, allowing developers to define the type of variables, function parameters, and return types. This helps catch errors during compile time.  
   Example:
   ```typescript
   let name: string = "John Doe";
   let age: number = 30;
   let isActive: boolean = true;

   function greet(person: string): string {
     return `Hello, ${person}`;
   }
   ```

2. **Interfaces**  
   Interfaces define the structure of objects in TypeScript. They are used to enforce the type shape of an object or a class.  
   Example:
   ```typescript
   interface Person {
     name: string;
     age: number;
     isEmployed?: boolean; // Optional property
   }

   const employee: Person = {
     name: "Alice",
     age: 28,
   };
   ```

3. **Classes and Access Modifiers**  
   TypeScript supports object-oriented programming with the `class` keyword. You can use access modifiers such as `public`, `private`, and `protected` to control class members' visibility.  
   Example:
   ```typescript
   class Employee {
     private id: number;
     public name: string;

     constructor(id: number, name: string) {
       this.id = id;
       this.name = name;
     }

     public getDetails(): string {
       return `ID: ${this.id}, Name: ${this.name}`;
     }
   }

   const emp = new Employee(101, "John");
   console.log(emp.getDetails());
   ```

4. **Generics**  
   Generics allow writing reusable components, ensuring type safety with a placeholder type.  
   Example:
   ```typescript
   function getArray<T>(items: T[]): T[] {
     return new Array<T>().concat(items);
   }

   const numArray = getArray<number>([1, 2, 3]);
   const strArray = getArray<string>(["a", "b", "c"]);
   ```

5. **Enums**  
   Enums define a set of named constants, making code more readable and maintainable.  
   Example:
   ```typescript
   enum Direction {
     Up,
     Down,
     Left,
     Right,
   }

   let move: Direction = Direction.Up;
   console.log(move); // Output: 0 (index value of Up)
   ```

6. **Modules and Import/Export**  
   TypeScript allows splitting code into modules using `export` and importing them using `import`.  
   Example:
   ```typescript
   // mathUtils.ts
   export function add(a: number, b: number): number {
     return a + b;
   }

   export function subtract(a: number, b: number): number {
     return a - b;
   }

   // main.ts
   import { add, subtract } from "./mathUtils";

   console.log(add(10, 20)); // Output: 30
   console.log(subtract(20, 10)); // Output: 10
   ```

7. **Union and Intersection Types**  
   Union types allow a variable to hold one of multiple types, while intersection types combine multiple types to create a new one.  
   Example:
   ```typescript
   // Union Type
   let value: number | string;
   value = 42; // OK
   value = "Hello"; // OK

   // Intersection Type
   interface A {
     name: string;
   }

   interface B {
     age: number;
   }

   type AB = A & B;

   const person: AB = {
     name: "John",
     age: 30,
   };
   ```

8. **Type Aliases**  
   You can define custom types using `type`, especially useful for complex types or unions.  
   Example:
   ```typescript
   type StringOrNumber = string | number;

   let data: StringOrNumber;
   data = 10; // OK
   data = "Hello"; // OK
   ```

9. **Decorators**  
   Decorators are metadata annotations available for classes, methods, and properties. They are widely used in Angular for dependency injection.  
   Example:
   ```typescript
   function readonly(target: Object, key: string): void {
     Object.defineProperty(target, key, {
       writable: false,
     });
   }

   class Car {
     @readonly
     brand: string = "Toyota";

     constructor(brand: string) {
       this.brand = brand;
     }
   }
   ```

10. **Utility Types**  
    TypeScript provides many built-in utility types such as `Partial`, `ReadOnly`, `Pick`, etc.  
    Example:
    ```typescript
    interface Todo {
      title: string;
      description: string;
    }

    const todo: Partial<Todo> = {
      title: "Learn TypeScript",
    };

    const readonlyTodo: Readonly<Todo> = {
      title: "Learn TypeScript",
      description: "Explore advanced concepts",
    };

    // readonlyTodo.title = "New Title"; // Error: Cannot assign to 'title' because it is a read-only property.
    ```

11. **Type Guards**  
    Used to narrow down types at runtime, ensuring correct type safety.  
    Example:
    ```typescript
    function isString(value: unknown): value is string {
      return typeof value === "string";
    }

    function print(value: string | number) {
      if (isString(value)) {
        console.log(`String: ${value}`);
      } else {
        console.log(`Number: ${value}`);
      }
    }
    ```

12. **Non-Null Assertion Operator**  
    When you are certain a value isn't `null` or `undefined`, you can use `!` to assert its non-null state.  
    Example:
    ```typescript
    let element = document.getElementById("app");
    console.log(element!.innerHTML); // Non-null assertion
    ```

These concepts form the foundation of TypeScript and are vital for building scalable applications while reducing runtime errors.

### <h3 style="background-color: #881337; color: white;display: inline-block;">Angular</h3>

Angular is a Javascript <span style="background-color: #fcd34d; color: black;display: inline-block;">binding framework</span> which binds the HTML UI and Javascript Model

### <h3 style="background-color: #881337; color: white;display: inline-block;">AngularJS vs Angular</h3>

| Feature                  | AngularJS                      | Angular                           |
|--------------------------|--------------------------------|-----------------------------------|
| **Type**                 | JavaScript Framework           | TypeScript-based Framework        |
| **Released**             | 2010                           | 2016                              |
| **Architecture**         | MVC (Model-View-Controller)    | Component-Based Architecture      |
| **Language**             | JavaScript                     | TypeScript                        |
| **Mobile Support**       | Partial                        | Full                              |
| **Performance**          | Slower                         | Faster due to Ahead-of-Time (AOT) |
| **Two-Way Binding**      | Supported                      | Supported                         |
| **Dependency Injection** | Limited                        | Advanced                          |
| **DOM Manipulation**     | Done in Controllers/Directives | Handled by the Component          |

### <h3 style="background-color: #881337; color: white;display: inline-block;">Angular CLI</h3>

The Angular CLI (Command Line Interface) is a powerful tool provided by the Angular team to <span style="background-color: #fcd34d; color: black;display: inline-block;">streamline development tasks, automate configurations, and simplify project creation and management</span>. It offers commands for generating Angular components, services, directives, modules, and more, as well as for managing builds and deployments.

#### **Features of Angular CLI**

- **Scaffolding:** Quickly generate components, directives, services, modules, guards, and other building blocks of an Angular application.
- **Configuration:** Automatically sets up build and configuration files for TypeScript, Webpack, Babel, etc.
- **Development Server:** Provides a built-in server (`ng serve`) for locally serving the application during development.
- **Build Automation:** Easily build the project for various environments (production, QA, development, etc.).
- **Linting and Testing:** Includes tools to lint the code (`ng lint`) and run unit tests (`ng test`) or end-to-end tests (`ng e2e`).
- **Version Updates:** Simplifies updating Angular and dependencies to the latest versions with `ng update`.
- **Code Optimization:** Facilitates Ahead-of-Time (AOT) compilation, Tree Shaking, and Bundle Splitting for optimized builds.

#### **Common Angular CLI Commands**

1. **Install Angular CLI**
   Install Angular CLI globally using npm:
   ```bash
   npm install -g @angular/cli
   ```

2. **Create a New Angular Application**
   Quickly create an Angular project with all default configurations:
   ```bash
   ng new my-angular-app
   ```
   Options include:

- `--routing` to include routing setup.
- `--style` to specify the stylesheet format (e.g., CSS, SCSS).

3. **Serve the Application**
   Launch a local development server with live reload:
   ```bash
   ng serve
   ```
   Access the app at `http://localhost:4200/`.

4. **Generate Components, Services, and More**
   Auto-generate boilerplate code for components, services, directives, etc.:
   ```bash
   ng generate component my-component
   ng generate service my-service
   ng generate module my-module
   ```
   Shorthand: `ng g c my-component`, `ng g s my-service`.

5. **Build the Application**
   Build the app for deployment:
   ```bash
   ng build --prod
   ```
   The `--prod` flag enables optimizations like AOT compilation and minification.

6. **Testing**
   Run unit tests:
   ```bash
   ng test
   ```
   Run end-to-end (e2e) tests:
   ```bash
   ng e2e
   ```

7. **Linting**
   Identify and fix linting issues:
   ```bash
   ng lint
   ```

8. **Update Angular and Dependencies**
   Update Angular and its dependencies to the latest versions:
   ```bash
   ng update @angular/core @angular/cli
   ```

9. **Add Features**
   Add new features such as Angular Material or PWA support:
   ```bash
   ng add @angular/material
   ng add @angular/pwa
   ```

#### **Advantages of Angular CLI**

- Speeds up development with boilerplate generation.
- Reduces the need for manual configuration and setup.
- Ensures consistency across projects.
- Integrates various tools (e.g., Webpack) seamlessly.
- Improves productivity with automated commands and tasks.

Angular CLI is an essential tool for Angular developers, empowering them to develop Angular applications with speed and efficiency.

### <h3 style="background-color: #881337; color: white;display: inline-block;">Directives in Angular</h3>

Angular directives are used to <span style="background-color: #fcd34d; color: black;display: inline-block;">extend the functionality of HTML</span> by adding behavior and modifying DOM elements. There are three types of directives in Angular:

1. **Component Directives:**  
   These are the most common directives. Components are directives with a template and are used to define UI.

   Example:
   ```typescript
   import { Component } from '@angular/core';

   @Component({
     selector: 'app-example',
     template: `<h1>Hello, I am a Component Directive!</h1>`
   })
   export class ExampleComponent {}
   ```

2. **Structural Directives:**  
   These directives change the structure of the DOM by adding or removing elements. Common examples are `*ngIf`, `*ngFor`, and `*ngSwitch`.

   Example:
   ```html
   <div *ngIf="isVisible">This block is visible.</div>
   <ul>
     <li *ngFor="let item of items">{{ item }}</li>
   </ul>
   ```

3. **Attribute Directives:**  
   These directives are used to change the behavior or appearance of a DOM element. A common example is `ngClass` or creating a custom directive.

   Example:
   ```typescript
   import { Directive, ElementRef, Renderer2 } from '@angular/core';

   @Directive({
     selector: '[appHighlight]'
   })
   export class HighlightDirective {
     constructor(private el: ElementRef, private renderer: Renderer2) {
       renderer.setStyle(el.nativeElement, 'background-color', 'yellow');
     }
   }
   ```

   Usage in HTML:
   ```html
   <p appHighlight>This paragraph will have a yellow background.</p>
   ```

Directives form a core part of Angular's ability to dynamically and declaratively interact with the DOM.

### <h3 style="background-color: #881337; color: white;display: inline-block;">Components in Angular</h3>

Components are <span style="background-color: #fcd34d; color: black;display: inline-block;">the fundamental building blocks</span> of an Angular application. They control a subset of the view (HTML page) and provide behavior for that view. A component consists of:

1. **TypeScript Class**: Defines the logic and data of the view.
2. **HTML Template**: Provides the structure or layout.
3. **CSS/SCSS**: Styles the view specific to the component.

#### **Key Elements of a Component**

- **Selector:** A unique identifier for the component, used in the HTML to include it.
- **Template:** Specifies the HTML structure for the component.
- **Style(s):** Optional CSS or SCSS for the component.

Example:

```typescript
import { Component } from '@angular/core';

@Component({
  selector: 'app-hello', // This is the component's unique selector.
  template: `<h1>Hello, {{ name }}!</h1>`, // Inline HTML template.
  styles: [`h1 { color: blue; }`] // Inline styling for the component.
})
export class HelloComponent {
  name: string = 'Angular'; // Defining data for the template.
}
```

To use this component, you reference its selector in the parent HTML file:

```html
<app-hello></app-hello>
```

### <h3 style="background-color: #881337; color: white;display: inline-block;">Modules in Angular</h3>

Modules in Angular are <span style="background-color: #fcd34d; color: black;display: inline-block;">used to group components, directives, services, and other building blocks together in a cohesive way</span>. An Angular application must have at least one module – the **root module** (typically named `AppModule`).

#### **Why Use Modules?**

- Organize an application into logical, reusable parts.
- Lazy load different modules to improve performance.
- Encapsulate specific features (e.g., sharing components or services).
- Manage dependencies.

#### **Key Elements of an Angular Module**

- **Imports**: Other modules required for this module.
- **Declarations**: Components, pipes, and directives that belong to this module.
- **Exports**: Components or directives that can be used in other modules.
- **Providers**: Services available throughout the module.
- **Bootstrap**: The root component to start the application (in the root module).

Example:

```typescript
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HelloComponent } from './hello.component';

@NgModule({
  declarations: [
    HelloComponent // Declaring the HelloComponent in the module
  ],
  imports: [
    BrowserModule // Importing necessary angular modules
  ],
  providers: [],
  bootstrap: [HelloComponent] // Bootstrapping this component in the root module
})
export class AppModule {}
```

#### **Grouping Features into Separate Modules**

For larger applications, different features can be grouped into **feature modules** and then imported into the root module.

Example of a feature module:

```typescript
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FeatureComponent } from './feature.component';

@NgModule({
  declarations: [
    FeatureComponent // Declare specific components of this feature.
  ],
  imports: [
    CommonModule
  ],
  exports: [
    FeatureComponent // Export it for usage in other parts of the app.
  ]
})
export class FeatureModule {}
```

Finally, to use the `FeatureModule` in the root module:

```typescript
import { FeatureModule } from './feature/feature.module';

@NgModule({
  imports: [FeatureModule],
  bootstrap: [AppComponent]
})
export class AppModule {}
```

### **Conclusion**

- **Components** define the user interface (UI) for a part of an application.
- **Modules** organize and encapsulate these components into logical units that can be imported/exported as needed.

### <h3 style="background-color: #881337; color: white;display: inline-block;">Decorators in Angular</h3>

Decorators in Angular are a <span style="background-color: #fcd34d; color: black;display: inline-block;">special type of functions</span> that can be attached to a class, method, property, or parameter and are used to modify or extend their behavior. They are a core part of TypeScript and Angular’s design. <span style="background-color: #fcd34d; color: black;display: inline-block;">In Angular, decorators are primarily used to define metadata for classes</span>, which Angular uses to configure and initialize those classes.

#### **Types of Angular Decorators**

Angular provides various types of decorators, each serving a specific purpose:

1. **Class Decorators**  
   These are used to define metadata for classes. For example, `@Component`, `@Directive`, and `@NgModule` are class decorators.

   Example:
   ```typescript
   import { Component } from '@angular/core';

   @Component({
     selector: 'app-hello',
     template: `<h1>Hello, {{name}}!</h1>`,
     styleUrls: ['./hello.component.css']
   })
   export class HelloComponent {
     name = 'Angular';
   }
   ```

2. **Property Decorators**  
   These are used to define metadata for properties inside a class. For example, `@Input` and `@Output` are commonly used property decorators in Angular.

   Example:
   ```typescript
   import { Component, Input } from '@angular/core';

   @Component({
     selector: 'app-child',
     template: `<p>{{ greeting }}</p>`
   })
   export class ChildComponent {
     @Input() greeting: string = ''; // Property decorated with @Input
   }
   ```

3. **Method Decorators**  
   These are used to define metadata for methods of a class. An example of a method decorator is `@HostListener`, which listens to DOM events and binds them to a method.

   Example:
   ```typescript
   import { Directive, HostListener } from '@angular/core';

   @Directive({
     selector: '[appClickTracker]'
   })
   export class ClickTrackerDirective {
     @HostListener('click', ['$event'])
     handleClick(event: Event) {
       console.log('Element clicked:', event.target);
     }
   }
   ```

4. **Parameter Decorators**  
   These are used to define metadata for parameters in class constructors. For instance, `@Inject` is a parameter decorator used in dependency injection.

   Example:
   ```typescript
   import { Component, Inject } from '@angular/core';
   import { DOCUMENT } from '@angular/common';

   @Component({
     selector: 'app-example',
     template: `<p>Check the console for document reference.</p>`
   })
   export class ExampleComponent {
     constructor(@Inject(DOCUMENT) private document: Document) {
       console.log(this.document); // Reference to the DOM Document object
     }
   }
   ```

#### **<span style="background-color: #fcd34d; color: black;display: inline-block;">Commonly Used Angular Decorators</span>**

1. **@Component:** Defines a component.
2. **@Directive:** Defines a directive.
3. **@Pipe:** Defines a pipe.
4. **@NgModule:** Defines a module.
5. **@Injectable:** Marks a class as injectable for dependency injection.
6. **@Input:** Binds a member variable of a child component to receive data from a parent component.
7. **@Output:** Binds a member of the child component to an event emitter to send data to a parent component.
8. **@HostListener:** Listens to DOM events and triggers the associated method.
9. **@ViewChild / @ViewChildren:** Accesses child components or elements in the DOM.

#### **How Decorators Work**

Decorators are syntactic sugar for functions that are executed at runtime. They receive metadata about the element they are decorating and can modify or configure the behavior of that element.

Example of how a `@Component` decorator works:

```typescript
function Component(metadata: any) {
  return function (constructor: Function) {
    constructor.prototype.metadata = metadata;
  };
}

@Component({
  selector: 'app-example',
  template: `<h1>Example</h1>`
})
class ExampleComponent {}
```

In this example, the custom `Component` function takes metadata (like `selector` and `template`) and applies it to the `ExampleComponent`.

#### **Conclusion**

Decorators make Angular’s architecture declarative and extensible. By providing metadata through decorators, Angular can manage the lifecycle, relationships, and interactions of components, services, directives, and more.

### <h3 style="background-color: #881337; color: white;display: inline-block;">Data Binding in Angular</h3>

Data Binding in Angular is a mechanism that allows <span style="background-color: #fcd34d; color: black;">seamless communication between the component and the DOM</span> (template). It enables the synchronization of data between the application's business logic and the user interface, making it dynamic and interactive.

#### **Types of Data Binding**

1. **One-Way Data Binding:**  
   In one-way data binding, the data flows in one direction—either from the component to the view (template) or from the view to the component.

   Examples:
  - **Interpolation:** Bind data from the component to the template.
    ```typescript
    import { Component } from '@angular/core';

    @Component({
      selector: 'app-example',
      template: `<h1>Hello, {{ name }}!</h1>` // Data flows from the component to the DOM
    })
    export class ExampleComponent {
      name = 'Angular';
    }
    ```

  - **Property Binding:** Bind a component property to a DOM property.
    ```typescript
    <img [src]="imageUrl" alt="Angular logo"> // One-way from the component
    ```

  - **Event Binding:**  
    Event binding allows communication from the view (template) to the component. It listens for events like clicks, input changes, or mouse movements and executes a method in the component. Event binding is done using parentheses `()` around the event name.

    Example:
    ```typescript
    import { Component } from '@angular/core';

    @Component({
      selector: 'app-example',
      template: `
        <button (click)="onButtonClick()">Click Me</button>
        <p>{{ message }}</p>
      `
    })
    export class ExampleComponent {
      message = '';

      onButtonClick() {
        this.message = 'Button clicked!';
      }
    }
    ```
    In this example, the `(click)` event in the button element is bound to the `onButtonClick` method in the component. When the button is clicked, the method is executed, and the `message` property is updated, which reflects in the UI.

    **Key Points:**
    - Event binding supports any DOM event, such as `click`, `input`, `mouseover`, etc.
    - The component controls the logic executed when an event is triggered.

2. **Two-Way Data Binding:**  
   This enables a bidirectional data flow, meaning any changes in the component are reflected in the view and vice versa. Two-way data binding is primarily used with form elements.

   Example:
   ```typescript
   import { Component } from '@angular/core';

   @Component({
     selector: 'app-example',
     template: `
       <input [(ngModel)]="name" placeholder="Enter your name">
       <p>Your name is: {{ name }}</p>
     `
   })
   export class ExampleComponent {
     name = '';
   }
   ```

   **Note:** Two-way data binding requires the `FormsModule` to be imported in the module.
   ```typescript
   import { NgModule } from '@angular/core';
   import { FormsModule } from '@angular/forms';

   @NgModule({
     imports: [FormsModule],
   })
   export class AppModule {}
   ```

#### **Benefits of Data Binding**

- Simplifies UI bindings by abstracting manual DOM manipulation.
- Keeps the UI and business logic in sync automatically.
- Makes building dynamic, responsive interfaces easier.

<h3 style="background-color: #881337; color: white;display: inline-block;">Angular Architecture</h3>

Angular is a framework for building client-side web applications using HTML, CSS, and TypeScript. <span style="background-color: #fcd34d; color: black;">Its architecture is based on the design principles of component-based development, dependency injection, and declarative UI construction</span>. Below is an overview of Angular's architecture.

<h4 style="background-color: #be185d; color: white;display: inline-block;">Key Building Blocks of Angular Architecture</h4>

1. **Modules (@NgModule)**  
   Modules are the fundamental building blocks of an Angular application. Each Angular app has at least one root module, typically named `AppModule`, and other feature modules to organize functionality into cohesive blocks.
  - A module declares components, directives, pipes, and services it manages.
  - Uses the `NgModule` decorator to define metadata about the module.

   Example:
   ```typescript
   import { NgModule } from '@angular/core';
   import { BrowserModule } from '@angular/platform-browser';
   import { AppComponent } from './app.component';

   @NgModule({
     declarations: [AppComponent],  // Declares components, directives, and pipes
     imports: [BrowserModule],      // Imports necessary Angular modules
     bootstrap: [AppComponent]      // Bootstraps the root component
   })
   export class AppModule {}
   ```

2. **Components (@Component)**  
   Components control a part of the user interface (UI) and interact with the template (HTML). Each component consists of:
  - A TypeScript class (business logic).
  - An HTML template (view).
  - A CSS/SCSS file (styling).

   Example:
   ```typescript
   import { Component } from '@angular/core';

   @Component({
     selector: 'app-root',
     templateUrl: './app.component.html',
     styleUrls: ['./app.component.css']
   })
   export class AppComponent {
     title = 'Angular App';  // Data passed to the template
   }
   ```

3. **Templates and Data Binding**  
   Angular templates are HTML with additional Angular-specific syntax for dynamic content and functionality using **data binding**.
  - **Interpolation**: Bind data from the component to the view. (`{{ value }}`)
  - **Property Binding**: Bind a property in the component to an HTML attribute. (`[attr]`)
  - **Event Binding**: Capture events from the DOM to the component. (`(event)`)
  - **Two-way Data Binding**: Synchronize data between the component and the template. (`[(ngModel)]`)

4. **Directives (@Directive)**  
   Directives are used to change the behavior or structure of the DOM. Angular provides three types of directives:
  - **Attribute Directives**: Modify the appearance or behavior of an element, e.g., `ngClass`, `ngStyle`.
  - **Structural Directives**: Change the DOM structure, e.g., `*ngIf`, `*ngFor`.
  - **Custom Directives**: User-defined custom functionality.

   Example:
   ```typescript
   import { Directive, ElementRef } from '@angular/core';

   @Directive({
     selector: '[appHighlight]'
   })
   export class HighlightDirective {
     constructor(private el: ElementRef) {
       this.el.nativeElement.style.backgroundColor = 'yellow'; // Adds highlight
     }
   }
   ```

5. **Services and Dependency Injection (@Injectable)**  
   Services in Angular provide shared functionality, such as fetching data, business logic, or utilities. They are typically injected into components using Angular's **dependency injection** system.

   Example:
   ```typescript
   import { Injectable } from '@angular/core';

   @Injectable({
     providedIn: 'root',  // Makes the service available throughout the app
   })
   export class DataService {
     getData() {
       return ['Data 1', 'Data 2', 'Data 3'];
     }
   }
   ```

6. **Routing (@RouterModule)**  
   Angular's **Router** enables navigation between views or components in a Single Page Application (SPA). Each route is mapped to a component.

   Example:
   ```typescript
   import { NgModule } from '@angular/core';
   import { RouterModule, Routes } from '@angular/router';
   import { HomeComponent } from './home/home.component';
   import { AboutComponent } from './about/about.component';

   const routes: Routes = [
     { path: '', component: HomeComponent },      // Root path
     { path: 'about', component: AboutComponent } // Route to About
   ];

   @NgModule({
     imports: [RouterModule.forRoot(routes)],
     exports: [RouterModule]
   })
   export class AppRoutingModule {}
   ```

<h4 style="background-color: #be185d; color: white;display: inline-block;">Angular Application Flow</h4>

1. **Bootstrapping**:  
   Angular applications start with a root module (`AppModule`) and a root component (`AppComponent`). The `main.ts` file bootstraps the application.

   ```typescript
   import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
   import { AppModule } from './app/app.module';

   platformBrowserDynamic().bootstrapModule(AppModule)
     .catch(err => console.error(err));
   ```

2. **Rendering**:  
   Angular renders the Root Component (`AppComponent`) in the `index.html` file using the selector defined in the `@Component` decorator.

3. **View Interaction**:  
   Components interact with templates through bindings and handle user inputs or events.

4. **Navigation**:  
   The `RouterModule` facilitates navigation between different parts of the app.

<h4 style="background-color: #be185d; color: white;display: inline-block;">Conclusion</h4>

Angular's architecture is modular, scalable, and designed for building dynamic web applications. It relies on key concepts like modularization, components, templates, dependency injection, and the powerful routing system to create robust client-side applications.

<h3 style="background-color: #881337; color: white;display: inline-block;">Routing in Angular</h3>

Routing in Angular is a mechanism to<span style="background-color: #eab308; color: black;"> navigate between different views or components of a Single Page Application (SPA)</span>. It allows users to move across various parts of the application while staying on a single HTML page.

<span style="background-color: #16a34a; color: black;">Angular provides the `RouterModule` to configure and manage routing features.</span>

---

<h4 style="background-color: #be185d; color: white;display: inline-block;">Key Concepts of Angular Routing</h4>

1. **Routes**:  
   Routes are objects that define navigation paths, their corresponding components, and optional configuration options.

   <span style="background-color: #16a34a; color: black;">A route object typically has a `path` (URL segment) and a `component` (to display).</span>

   Example:
   ```typescript
   const routes: Routes = [
     { path: '', component: HomeComponent },   // Default route
     { path: 'about', component: AboutComponent }, // Maps '/about' route to AboutComponent
   ];
   ```

2. **RouterModule**:  
   The `RouterModule` is an Angular module that provides the necessary tools to enable routing. Developers use `RouterModule.forRoot()` for root-level routers and `RouterModule.forChild()` for child-level routing.

3. **Router Outlet**:  
   The `<router-outlet>` directive serves as a placeholder in the view, where the routed component will be displayed.  
   Example:
   ```html
   <router-outlet></router-outlet>
   ```

4. **Router Link**:  
   The `routerLink` directive is used to navigate between views without reloading the page. It provides smooth navigation within the SPA.  
   Example:
   ```html
   <a routerLink="/about">Go to About Page</a>
   ```

---

<h4 style="background-color: #be185d; color: white;display: inline-block;">Implementing Routing in Angular</h4>

Here is an example of setting up routing in an Angular application:

**Step 1: Create Components**  
Create the necessary components, such as `HomeComponent` and `AboutComponent`.

Command:

```bash
ng generate component home
ng generate component about
```

**Step 2: Define Routes in AppRoutingModule**  
Create and configure the routes in a dedicated `AppRoutingModule`.

Example:

```typescript
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';

const routes: Routes = [
  { path: '', component: HomeComponent },       // Root route
  { path: 'about', component: AboutComponent }, // About route
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
```

**Step 3: Add RouterModule to AppModule**  
Import the `AppRoutingModule` into the `AppModule` to enable routing.

Example:

```typescript
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [AppComponent],
  imports: [BrowserModule, AppRoutingModule],
  bootstrap: [AppComponent],
})
export class AppModule {}
```

**Step 4: Use `<router-outlet>` in AppComponent Template**  
Ensure the `AppComponent` contains the `<router-outlet>` directive to display the routed views.

Example:

```html
<h1>Welcome to My Angular App</h1>
<nav>
  <a routerLink="/">Home</a> |
  <a routerLink="/about">About</a>
</nav>
<router-outlet></router-outlet>
```

**Step 5: Test the Application**  
Run the project using `ng serve` and navigate between the defined routes.

---

<h4 style="background-color: #be185d; color: white;display: inline-block;">Advantages of Using Angular Routing</h4>

- <span style="background-color: #16a34a; color: black;">Improves navigation and user experience in SPAs.</span>
- <span style="background-color: #16a34a; color: black;">Provides built-in support for lazy loading.</span>
- <span style="background-color: #16a34a; color: black;">Enables reusable and modular code with child routes.</span>
- Handles route guards for securing specific URLs.

---

<h4 style="background-color: #be185d; color: white;display: inline-block;">Conclusion</h4>
Routing in Angular is an essential feature for developing dynamic and scalable SPAs. It provides developers with the tools to create seamless navigation between views/components while maintaining a modular architecture.

<h3 style="background-color: #881337; color: white;display: inline-block;">Lazy Loading in Angular</h3>

Lazy loading in Angular is an efficient design pattern that involves <span style="background-color: #eab308; color: black;">loading JavaScript modules only when they are needed</span>. This helps reduce the initial load time of the application by splitting it into smaller chunks, improving performance and optimizing resources.

<h4 style="background-color: #be185d; color: white;display: inline-block;">Key Benefits of Lazy Loading</h4>

- <span style="background-color: #16a34a; color: black;">Improves application load time</span> by loading fewer resources initially.
- <span style="background-color: #16a34a; color: black;">Reduces resource consumption</span> by loading modules only when required.
- Helps in <span style="background-color: #16a34a; color: black;">maintaining modular architecture</span> for better code organization.

<h4 style="background-color: #be185d; color: white;display: inline-block;">How Lazy Loading Works in Angular</h4>

Lazy loading in Angular is achieved using the `loadChildren` property in the route configuration. This property specifies the path to a module that will only be loaded when its route is accessed.

<h4 style="background-color: #be185d; color: white;display: inline-block;">Steps to Implement Lazy Loading</h4>

**Step 1: Create Feature Module**  
Generate a new feature module along with its routing module.

```bash
ng generate module feature --route feature --module app.module
```

This command creates a new module with routing pre-configured for lazy loading.

**Step 2: Define Routes in Feature Module**  
Add the routes for the specific feature in its `feature-routing.module.ts` file.

Example:

```typescript
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FeatureComponent } from './feature.component';

const routes: Routes = [
  { path: '', component: FeatureComponent } // Lazy loaded route
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FeatureRoutingModule {}
```

**Step 3: Configure Lazy Loading in App Routing Module**  
Specify the path and use the `loadChildren` function to configure lazy loading in your main `app-routing.module.ts`.

Example:

```typescript
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { 
    path: 'feature', 
    loadChildren: () => import('./feature/feature.module').then(m => m.FeatureModule) 
  } // Lazy loaded module
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
```

**Step 4: Add Router Outlet**  
Ensure `<router-outlet>` is included in the `AppComponent` template to enable route rendering.

Example:

```html
<h1>Welcome to Lazy Loading Example</h1>
<nav>
  <a routerLink="/">Home</a> |
  <a routerLink="/feature">Feature Module</a>
</nav>
<router-outlet></router-outlet>
```

<h4 style="background-color: #be185d; color: white;display: inline-block;">Advantages of Lazy Loading</h4>

- <span style="background-color: #16a34a; color: black;">Minimizes application bundle size</span>, leading to faster initial loads.
- <span style="background-color: #16a34a; color: black;">Improves scalability</span> by modularizing different parts of the application.
- Enables <span style="background-color: #16a34a; color: black;">on-demand loading</span> of features, improving user experience.

<h4 style="background-color: #be185d; color: white;display: inline-block;">Conclusion</h4>

Lazy loading is a powerful mechanism in Angular that promotes performance optimization and modular development. By loading only the required parts of the application dynamically, developers can ensure efficient use of resources and a smoother user experience.
