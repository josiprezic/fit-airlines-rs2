import 'package:intl/intl.dart';
import 'dart:core';

class DateDecorator {
  static String decorateMinDay(String? inputDate) {
    if (inputDate == null) {
      return '';
    }
    DateTime date = inputDate!.asDateTime();
    var result = DateFormat('dd/MM/yyyy').format(date);
    return result;
  }
}

extension on DateTime {
  String asString() {
    return DateFormat('yyyy-MM-dd hh:mm:ss').format(this);
  }
}

extension on String {
  DateTime asDateTime() {
    return DateTime.parse(this);
  }
}
