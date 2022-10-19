class FlightSeat {
  int row;
  int column;
  bool available;
  bool selected;

  FlightSeat(this.row, this.column, this.available, {this.selected = false});

  int getSeatNumber() {
    int seatNumber = ((row) * 6) + column;
    return seatNumber;
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
}
