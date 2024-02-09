int led = 3;

void setup() {
  pinMode(led, OUTPUT);
  Serial.begin(9600);
  Serial.println("Type 'help' for more info.");
}

void loop() {
  String command = Serial.readString();

  if (command != NULL) {
    if (command == "help") {
      Serial.println("Commands:");
      Serial.println("- on");
      Serial.println("- off");
    } else if (command == "on") {
      digitalWrite(led, HIGH);
      Serial.println("LED has been turned on.");
    } else if (command == "off") {
      digitalWrite(led, LOW);
      Serial.println("LED has been turned off.");
    } else {
      Serial.println("Unknown command");
    }
  }
}
