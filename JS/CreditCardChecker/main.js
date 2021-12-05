// All valid credit card numbers
const valid1 = [4, 5, 3, 9, 6, 7, 7, 9, 0, 8, 0, 1, 6, 8, 0, 8];
const valid2 = [5, 5, 3, 5, 7, 6, 6, 7, 6, 8, 7, 5, 1, 4, 3, 9];
const valid3 = [3, 7, 1, 6, 1, 2, 0, 1, 9, 9, 8, 5, 2, 3, 6];
const valid4 = [6, 0, 1, 1, 1, 4, 4, 3, 4, 0, 6, 8, 2, 9, 0, 5];
const valid5 = [4, 5, 3, 9, 4, 0, 4, 9, 6, 7, 8, 6, 9, 6, 6, 6];

// All invalid credit card numbers
const invalid1 = [4, 5, 3, 2, 7, 7, 8, 7, 7, 1, 0, 9, 1, 7, 9, 5];
const invalid2 = [5, 7, 9, 5, 5, 9, 3, 3, 9, 2, 1, 3, 4, 6, 4, 3];
const invalid3 = [3, 7, 5, 7, 9, 6, 0, 8, 4, 4, 5, 9, 9, 1, 4];
const invalid4 = [6, 0, 1, 1, 1, 2, 7, 9, 6, 1, 7, 7, 7, 9, 3, 5];
const invalid5 = [5, 3, 8, 2, 0, 1, 9, 7, 7, 2, 8, 8, 3, 8, 5, 4];

// Can be either valid or invalid
const mystery1 = [3, 4, 4, 8, 0, 1, 9, 6, 8, 3, 0, 5, 4, 1, 4];
const mystery2 = [5, 4, 6, 6, 1, 0, 0, 8, 6, 1, 6, 2, 0, 2, 3, 9];
const mystery3 = [6, 0, 1, 1, 3, 7, 7, 0, 2, 0, 9, 6, 2, 6, 5, 6, 2, 0, 3];
const mystery4 = [4, 9, 2, 9, 8, 7, 7, 1, 6, 9, 2, 1, 7, 0, 9, 3];
const mystery5 = [4, 9, 1, 3, 5, 4, 0, 4, 6, 3, 0, 7, 2, 5, 2, 3];

// An array of all the arrays above
const batch = [valid1, valid2, valid3, valid4, valid5, invalid1, invalid2, invalid3, invalid4, invalid5, mystery1, mystery2, mystery3, mystery4, mystery5];

let validateCred = (arrayIn) => {
    //create copy first

  let arrayLen = arrayIn.length;
  let check = arrayIn[arrayLen - 1];
  let checkArray = arrayIn.slice(0,arrayLen-1);
  let revArray = checkArray.reverse();
  let sum =0;

  for (i = 0;i<revArray.length;i++){
    if(i % 2 == 0 || i == 0){
      revArray[i] *=2;
      
      if(revArray[i]>9){
        revArray[i] -= 9;
      }
    }
  }

  //sum array
const reducer = (previousValue, currentValue) => previousValue + currentValue;
// add check to sum for total
sum = check + revArray.reduce(reducer);
if (sum % 10 === 0){
  return true;
}else {
  return false;
}

}//end validateCred

let findInvalidCards = (arrayIn) => {
  let invalidArray = [];
  
  for (let i = 0; i < arrayIn.length; i++){
    let isValid = validateCred(arrayIn[i]);
    if (!isValid){
      invalidArray.push(arrayIn[i]);
    }
  }
  return invalidArray;
}//end findInvalidCards

let idInvalidCardCompanies = (arrayIn) => {
    let companyArray =[];

    for (let i = 0; i < arrayIn.length; i++){
        let j = 0;
        let exists;
        //iterate through array at first element and check if the company exists in new company array. if not, push.
        if(arrayIn[i][j] === 3){
            exists = companyArray.indexOf('Amex (American Express)')
            if (exists == -1){
            companyArray.push('Amex (American Express)')
            }
        }else if(arrayIn[i][j] === 4){
            exists = companyArray.indexOf('Visa')
            if (exists == -1){
            companyArray.push('Visa')
            }
        }else if(arrayIn[i][j] === 5){
            exists = companyArray.indexOf('Mastercard')
            if (exists == -1){
            companyArray.push('Mastercard')
            }
        }else if(arrayIn[i][j] === 6){
            exists = companyArray.indexOf('Discover')
            if (exists == -1){
            companyArray.push('Discover')
            }
        }else {
            return console.log('Company not found' + arrayIn[i])
        }

    }
    return companyArray;
}//end idInvalidCardCompanies

let invalidCards = findInvalidCards(batch);
let companies = idInvalidCardCompanies(invalidCards);
console.log(companies)