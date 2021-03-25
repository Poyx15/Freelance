void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  
  for (int x = 0; x<10; x++){
    pinMode (x, OUTPUT);
  }
}
String readString;
void loop() {
  // put your main code here, to run repeatedly:
   while (Serial.available()) {
    delay(3);  
    char c = Serial.read();
    readString += c; 
  }

  //+++++++++++++Sequence 1
  Serial.print(readString);

    // Wash A PIN 2
    if (readString.equals("WashA\n")) {
      digitalWrite(2, HIGH);
      readString="";
      
      delay(200);
      digitalWrite(2, LOW);
      readString="";
    }
    

}
