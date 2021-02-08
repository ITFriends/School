int a = 10;
int b = 4;
bool c = a == b; // false


int a = 10;
int b = 4;
bool c = a != b;    // true
bool d = a != 10;     // false

int a = 10;
int b = 4;
bool c = a < b; // false

int a = 10;
int b = 4;
bool c = a > b;     // true
bool d = a > 25;    // false

int a = 10;
int b = 4;
bool c = a <= b;     // false
bool d = a <= 25;    // true

int a = 10;
int b = 4;
bool c = a >= b;     // true
bool d = a >= 25;    // false

bool x1 = (5 > 6) | (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
bool x2 = (5 > 6) | (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false


bool x1 = (5 > 6) &(4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
bool x2 = (5 < 6) & (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true


bool x1 = (5 > 6) || (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
bool x2 = (5 > 6) || (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false

bool x1 = (5 > 6) && (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
bool x2 = (5 < 6) && (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true


bool a = true;
bool b = !a;    // false


bool x5 = (5 > 6) ^(4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
bool x6 = (50 > 6) ^ (4 / 2 < 3); // 50 > 6 - true, 4/2 < 3 - true, поэтому возвращается false
