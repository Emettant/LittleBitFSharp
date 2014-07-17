namespace MyFunctionalLibrary
open System

type IRateFactory = 
        abstract GetRateByDate : DateTime -> decimal

type ConstantRateFactory(value) as this = 
    interface IRateFactory with
        member this.GetRateByDate(d) = value
    end
and DifferentRateFactory(value) as this = 
    interface IRateFactory with
        member this.GetRateByDate(d) = value * 1m / (decimal d.Month)
    end

type Bond(issuanceTime : DateTime, maturity : int, amount : decimal, rateFactory : IRateFactory) as this =
    //new(issuanceTime : DateTime, years : int, constRate : decimal) = Bond(issuanceTime, ConstantRateFactory(years, constRate))
    member this.Rate = rateFactory.GetRateByDate(issuanceTime)
    member this.Maturity = maturity
    member this.Amount = amount
    member this.YearYield = amount * this.Rate
    member this.Issuance = issuanceTime
    member this.Expiration = issuanceTime.AddYears(maturity)

module Solution = 
    let CalcProfits (bond : Bond) (timeOfReBuying : DateTime) (discount : decimal) =
        let diff = new DateTime((timeOfReBuying - bond.Issuance).Ticks)
        let yieldsForFirst = decimal diff.Year * bond.YearYield
        let yieldsForSecond = decimal (bond.Maturity - diff.Year) * bond.YearYield
//        printfn "%d" diff.Year 
//        printfn "%f" yieldsForFirst
        (yieldsForFirst - discount*bond.Amount, yieldsForSecond + discount*bond.Amount)
        
   
module Tools =
    //fold for every element in list
    let foldStates f beg l = 
        let rec loop cur acc = function
            | [] -> List.rev acc
            | head::ls -> loop (f cur head) ((f cur head)::acc) ls
        loop beg [] l
   
//Test Code Begin
//
//let cr = ConstantRateFactory(0.1m)
//let b = new Bond(Convert.ToDateTime("25 Dec 1988"), 30, 300m, cr)
//let someTime = Convert.ToDateTime("12 Apr 2002")
//Solution.CalcProfits b someTime 0.13m
//
//Test Code End


//    
//let e =  ExponentialRateFactory( 5, 0.5m, 0.05)
//(e:>IRateFactory).GetRateList()
//
//let c = new ConstantRateFactory(5,0.05m)
//let ls = (c:>IRateFactory).GetRateList()

//
//foldStates (fun a b -> a.ToString() + b.ToString()) "" ls
//
//
//b.yields
//b.Expiration
//let b = Bond()
//b.AddOwnerAtTime(Convert.ToDateTime("25 Dec 1989"))
//b.Owners
//
 