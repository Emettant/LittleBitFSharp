namespace MyFunctionalLibrary
open System

type IRateFactory = 
        abstract GetRateList : unit -> decimal list

type ConstantRateFactory(length, value) as this = 
    interface IRateFactory with
        member this.GetRateList() = [for i in 1..length -> value]
    end
and ExponentialRateFactory(length, startValue : decimal, speed : double) as this = 
    interface IRateFactory with
        member this.GetRateList() = [for i in 1..length -> startValue * decimal (exp -(speed * double (i-1)))]
    end

type Bond(issuanceTime : DateTime, rateFactory : IRateFactory) as this =
    let rates = rateFactory.GetRateList()
    let years = rates.Length
    new(issuanceTime : DateTime, years : int, constRate : decimal) = Bond(issuanceTime, ConstantRateFactory(years, constRate))
    member this.Rates = rates
    member this.Issuance = issuanceTime
    member this.Expiration = issuanceTime.AddYears(years)

module Solution = 
    let CalcProfits (bond : Bond) (timeOfReBuying : DateTime) (discount : decimal) (amount : decimal) =
        let diff = new DateTime((timeOfReBuying - bond.Issuance).Ticks)
        let fullYears = diff.Year
        let yieldsFirst = Seq.fold (fun a b -> a * (1m + b) ) 1m (Seq.take fullYears bond.Rates)
        let yieldsFull = Seq.fold (fun a b -> a * (1m + b) ) 1m bond.Rates
        let yieldsSecond = yieldsFull - yieldsFirst
        new Tuple<decimal,decimal>(yieldsFirst - discount*amount, yieldsSecond + discount*amount)
        
   
module Tools =
    //fold for every element in list
    let foldStates f beg l = 
        let rec loop cur acc = function
            | [] -> List.rev acc
            | head::ls -> loop (f cur head) ((f cur head)::acc) ls
        loop beg [] l
   
//    
//let e =  ExponentialRateFactory( 5, 0.5m, 0.05)
//(e:>IRateFactory).GetRateList()
//
//let c = new ConstantRateFactory(5,0.05m)
//let ls = (c:>IRateFactory).GetRateList()
//let someTime = Convert.ToDateTime("12 Apr 2002")
//
//foldStates (fun a b -> a.ToString() + b.ToString()) "" ls
//
//let b = new Bond(Convert.ToDateTime("25 Dec 1988"), 30, 0.20m)
//Solution.CalcProfits b someTime 0.13m 300m 
//
//b.yields
//b.Expiration
//let b = Bond()
//b.AddOwnerAtTime(Convert.ToDateTime("25 Dec 1989"))
//b.Owners
//
 