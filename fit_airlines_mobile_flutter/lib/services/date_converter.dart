import 'package:intl/intl.dart';
import 'dart:core';

extension on DateTime {
  String asString() {
    return DateFormat('yyyy-MM-dd hh:mm:ss').format(this);
  }
}
