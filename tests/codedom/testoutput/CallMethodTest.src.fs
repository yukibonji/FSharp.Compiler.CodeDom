﻿
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace global

namespace NSPC
    // Generated by F# CodeDom
    #nowarn "49" // uppercase argument names
    #nowarn "67" // this type test or downcast will always hold
    #nowarn "66" // this upcast is unnecessary - the types are identical
    #nowarn "58" // possible incorrect indentation..
    #nowarn "57" // do not use create_DelegateEvent
    #nowarn "51" // address-of operator can occur in the code
    #nowarn "1183" // unused 'this' reference
    open System
    
    exception ReturnException669185127be84376a14d418fd6d43c97 of obj
    exception ReturnNoneException669185127be84376a14d418fd6d43c97
    [<AutoOpen>]
    module FuncConvertFinalOverload669185127be84376a14d418fd6d43c97 =
      // This extension member adds to the FuncConvert type and is the last resort member in the method overloading rules. 
      type global.Microsoft.FSharp.Core.FuncConvert with
          /// A utility function to convert function values from tupled to curried form
          static member FuncFromTupled (f:'T -> 'Res) = f
    
    type
        
        TEST = class
            new() as this =
                {
                }
            abstract CallingNewScenario : int -> int
            default this.CallingNewScenario  (i:int) =
                let mutable i = i
                let mutable (t:ClassWVirtualMethod) = ((new ClassWNewMethod() :> obj) :?> ClassWVirtualMethod)
                let mutable (x1:int) = 0
                let mutable (x2:int) = 0
                x1 <- ((t :> obj) :?> ClassWNewMethod).VirtualMethod(i)
                x2 <- t.VirtualMethod(i)
                (x1 - x2)
            
            abstract CallParamsMethods : unit -> int
            default this.CallParamsMethods  () =
                let mutable (t:TEST) = new TEST()
                let mutable (_val:int) = 0
                _val <- t.NoParamsMethod()
                t.MultipleParamsMethod(78, _val)
            
            abstract MultipleParamsMethod : int * int -> int
            default this.MultipleParamsMethod  (a:int, b:int) =
                let mutable a = a
                let mutable b = b
                (a + b)
            
            abstract NoParamsMethod : unit -> int
            default this.NoParamsMethod  () =
                16
            
            abstract CallingOverrideScenario : int -> int
            default this.CallingOverrideScenario  (i:int) =
                let mutable i = i
                let mutable (t:ClassWVirtualMethod) = ((new ClassWOverrideMethod() :> obj) :?> ClassWVirtualMethod)
                t.VirtualMethod(i)
        end
    
    and
        
        ClassWVirtualMethod = class
            new() as this =
                {
                }
            abstract VirtualMethod : int -> int
            default this.VirtualMethod  (a:int) =
                let mutable a = a
                a
        end
    
    and
        
        ClassWNewMethod = class
            inherit ClassWVirtualMethod 
            new() as this =
                {
                }
            abstract VirtualMethod : int -> int
            default this.VirtualMethod  (a:int) =
                let mutable a = a
                (2 * a)
        end
    
    and
        
        ClassWOverrideMethod = class
            inherit ClassWVirtualMethod 
            new() as this =
                {
                }
            override this.VirtualMethod  (a:int) =
                let mutable a = a
                (2 * a)
        end
    
    and
        
        TEST7 = class
            new() as this =
                {
                }
            abstract CallingOverloadedMethods : int -> int
            default this.CallingOverloadedMethods  (i:int) =
                let mutable i = i
                let mutable (one:int) = this.OverloadedMethod(i, i)
                let mutable (two:int) = this.OverloadedMethod(i)
                (one - two)
            
            abstract OverloadedMethod : int * int -> int
            default this.OverloadedMethod  (a:int, b:int) =
                let mutable a = a
                let mutable b = b
                (b + a)
            
            abstract OverloadedMethod : int -> int
            default this.OverloadedMethod  (a:int) =
                let mutable a = a
                a
        end

namespace NSPC2
    // Generated by F# CodeDom
    #nowarn "49" // uppercase argument names
    #nowarn "67" // this type test or downcast will always hold
    #nowarn "66" // this upcast is unnecessary - the types are identical
    #nowarn "58" // possible incorrect indentation..
    #nowarn "57" // do not use create_DelegateEvent
    #nowarn "51" // address-of operator can occur in the code
    #nowarn "1183" // unused 'this' reference
    open NSPC
    
    exception ReturnException669185127be84376a14d418fd6d43c97 of obj
    exception ReturnNoneException669185127be84376a14d418fd6d43c97
    [<AutoOpen>]
    module FuncConvertFinalOverload669185127be84376a14d418fd6d43c97 =
      // This extension member adds to the FuncConvert type and is the last resort member in the method overloading rules. 
      type global.Microsoft.FSharp.Core.FuncConvert with
          /// A utility function to convert function values from tupled to curried form
          static member FuncFromTupled (f:'T -> 'Res) = f
    
    type
        
        TEST = class
            new() as this =
                {
                }
            abstract CallingOverrideScenario : int -> int
            default this.CallingOverrideScenario  (i:int) =
                let mutable i = i
                let mutable (t:NSPC.ClassWVirtualMethod) = ((new NSPC.ClassWOverrideMethod() :> obj) :?> NSPC.ClassWVirtualMethod)
                t.VirtualMethod(i)
        end