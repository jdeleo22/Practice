// Returns a random DNA base
const returnRandBase = () => {
  const dnaBases = ['A', 'T', 'C', 'G'];
  return dnaBases[Math.floor(Math.random() * 4)];
};

// Returns a random single stand of DNA containing 15 bases
const mockUpStrand = () => {
  const newStrand = [];
  for (let i = 0; i < 15; i++) {
    newStrand.push(returnRandBase());
  }
  return newStrand;
};

let pAequorFactory = (number,baseArrayIn) => {
return {

  specimenNum: number,
  dna: baseArrayIn,

  mutate(){
    let randomStrand = Math.floor(Math.random() * 15);
    let selectedStrand = baseArrayIn[randomStrand]
    let newStrand = '';
    if (selectedStrand == 'A'){
      do {
        newStrand = returnRandBase();
      }while(newStrand == 'A');
      baseArrayIn[randomStrand] = newStrand;

    }else if (selectedStrand == 'T'){
      do {
        newStrand = returnRandBase();
      }while(newStrand == 'T');
      baseArrayIn[randomStrand] = newStrand;

    }else if (selectedStrand == 'C'){
      do {
        newStrand = returnRandBase();
      }while(newStrand == 'C');
      baseArrayIn[randomStrand] = newStrand;

    }else if (selectedStrand == 'G'){
      do {
        newStrand = returnRandBase();
      }while(newStrand == 'G');
      baseArrayIn[randomStrand] = newStrand;

    }
    return this.dna;
  },//end mutate function

  compareDNA(pAeqObj){
    let count = 0;

    for (let i = 0; i < this.dna.length; i++){
      if (this.dna[i] === pAeqObj.dna[i]) {
        count++;
        continue;
      }
      if (i = this.dna.length-1){
        console.log(`Comparing DNA from specimen ${this.specimenNum} and ${pAeqObj.specimenNum}`)
      }
    }
    //find % in common
    let commonality = Math.floor((100 / 15) * count)
    return `Specimen ${this.specimenNum} and ${pAeqObj.specimenNum} have ${commonality}% DNA in common`
  },//end compareDNA

  willLikelySurvive() {                                       
    let counter = 0;           
      for (let i = 0; i < this.dna.length; i++) {           
        if (this.dna[i] == "C" || this.dna[i] == "G" ) {     
          counter += 1;                                       
        }  
      }
     if((Math.floor((100 / 15) * counter) > 60)){
      return true;
     }else {
       return false;
     }
    
  },//end willLikelySurvive

  complementaryStrand() {                                 
    let complementaryStrand = [];

    for (let i = 0; i < this.dna.length; i++) {     
      if (this.dna[i] === "A") {
         complementaryStrand.push("T");
         }else if (this.dna[i] === "T") {
           complementaryStrand.push("A"); 
          }else if (this.dna[i] === "C") {
             complementaryStrand.push("G"); 
            }else if (this.dna[i] === "G") { 
              complementaryStrand.push("C"); 
            }else {
                complementaryStrand.push(this.dna[i]);
              }
    }
    return `Original DNA strand: ${this.dna}\n Complementary DNA strand: ${complementaryStrand}`
    }
}
}//end pAequorFactory

//create 30 instances of pAequor that will survive
let createSurvivors = () =>{
let survivorArray = [];
while(survivorArray.length < 30){
  let i = 1;
 let temp = pAequorFactory(i,mockUpStrand());
 if (temp.willLikelySurvive()){
  survivorArray.push(temp.dna);
 }
 i++;
}
return survivorArray;
}


let test1 = pAequorFactory(1,mockUpStrand());
let test2 = pAequorFactory(2,mockUpStrand());

let survivors = createSurvivors();