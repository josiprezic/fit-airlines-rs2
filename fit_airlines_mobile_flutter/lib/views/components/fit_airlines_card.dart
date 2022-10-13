import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class FitAirlinesCard extends StatelessWidget {
  String title;
  String rightTitle;
  Image image;
  Function onCardClick;

  FitAirlinesCard({
    required this.title,
    this.rightTitle = '',
    required this.image,
    required this.onCardClick,
  });

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: () {
        this.onCardClick();
      },
      child: Container(
        height: 150,
        margin: EdgeInsets.only(left: 10, top: 8, right: 10, bottom: 2),
        child: Stack(
          children: [
            Positioned.fill(
              child: ClipRRect(
                borderRadius: BorderRadius.circular(10),
                child: image,
              ),
            ),
            Positioned(
              bottom: 0,
              left: 0,
              right: 0,
              top: 0,
              child: Container(
                height: 120,
                decoration: BoxDecoration(
                  border: Border.all(color: Colors.black54, width: 1.0),
                  borderRadius: BorderRadius.circular(10),
                  gradient: LinearGradient(
                    begin: Alignment.bottomCenter,
                    end: Alignment.topCenter,
                    colors: [
                      Colors.black.withOpacity(0.8),
                      Colors.transparent,
                      Colors.transparent,
                    ],
                  ),
                ),
              ),
            ),
            Positioned(
              bottom: 0,
              left: 0,
              child: Row(
                children: [
                  Container(
                    padding: EdgeInsets.all(10),
                    child: Text(
                      title,
                      style: TextStyle(fontSize: 18, color: Colors.white),
                    ),
                  )
                ],
              ),
            ),
            Positioned(
              bottom: 0,
              right: 0,
              child: Row(
                children: [
                  Container(
                    padding: EdgeInsets.all(10),
                    child: Text(
                      rightTitle,
                      style: TextStyle(fontSize: 18, color: Colors.white),
                    ),
                  )
                ],
              ),
            )
          ],
        ),
      ),
    );
  }
}