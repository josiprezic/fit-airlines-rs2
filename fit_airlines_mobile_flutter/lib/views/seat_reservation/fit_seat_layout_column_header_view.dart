import 'package:flutter/material.dart';

class FitSeatLayoutColumnHeaderView extends StatelessWidget {
  const FitSeatLayoutColumnHeaderView({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    List<Widget> columnHeaderItems = ['A', 'B', 'C', 'D', 'E', 'F']
        .map((columnName) => getSeatColumnHeaderItem(columnName))
        .toList();
    columnHeaderItems.insert(3, getSeatSpacer());
    return Row(children: columnHeaderItems);
  }

  Widget getSeatColumnHeaderItem(String columnName) {
    return Expanded(
      child: Padding(
        padding: const EdgeInsets.only(
          left: 3.0,
          right: 3.0,
          top: 10.0,
          bottom: 10.0,
        ),
        child: Center(
          child: Text(
            columnName,
            style: TextStyle(fontSize: 18),
          ),
        ),
      ),
    );
  }

  Widget getSeatSpacer({String rowNumberString = ''}) {
    return SizedBox(
      width: 50,
      child: Center(
        child: Text(
          rowNumberString,
          style: TextStyle(fontSize: 18),
        ),
      ),
    );
  }
}
