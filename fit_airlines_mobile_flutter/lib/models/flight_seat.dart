class FlightSeat {
  int row;
  int column;
  bool available;
  bool selected;

  FlightSeat(this.row, this.column, this.available, {this.selected = false});

  static FlightSeat getFrom(String seatString) {
    var rowCalc = seatString.substring(1);
    var colCalc = seatString[0];
    return FlightSeat(int.parse(rowCalc), FlightSeat.getSeatColumnNumber(colCalc), true, selected: true);
  }

  int getSeatNumber() {
    int seatNumber = ((row) * 6) + column;
    return seatNumber;
  }

  int getSeatIndex() {
    return (row - 1) * 6;
  }

  String getSeatString() {
    return getSeatColumnString() + row.toString();
  }

  String getSeatColumnString() {
    switch (column) {
      case 1:
        return 'A';
      case 2:
        return 'B';
      case 3:
        return 'C';
      case 4:
        return 'D';
      case 5:
        return 'E';
      case 6:
        return 'F';
      default:
        return 'COL';
    }
  }

  static int getSeatColumnNumber(String columnLetter) {
    switch (columnLetter) {
      case 'A':
        return 1;
      case 'B':
        return 2;
      case 'D':
        return 3;
      case 'D':
        return 4;
      case 'E':
        return 5;
      case 'F':
        return 6;
      default:
        print('ERROR: getSeatColumnNumber');
        return 0;
    }
  }
}
