int led = 3;
int brightness = 0;
int fading = 5;

void setup() {
    pinMode(led, OUTPUT);
}

void loop() {
    analogWrite(led, brightness);
    brightness += fading;
    delay(25);

    if (brightness == 0 || brightness == 255) {
        fading = -fading;
    }
}