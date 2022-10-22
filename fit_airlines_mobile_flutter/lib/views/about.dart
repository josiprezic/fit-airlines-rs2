import 'package:fit_airlines_mobile_flutter/views/components/fit_horizontal_divider.dart';
import 'package:flutter/material.dart';

class AboutView extends StatefulWidget {
  const AboutView({Key? key}) : super(key: key);

  @override
  State<AboutView> createState() => _AboutViewState();
}

class _AboutViewState extends State<AboutView> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text('FIT'),
        ),
        body: SingleChildScrollView(
          child: Padding(
            padding: const EdgeInsets.all(16.0),
            child: Column(
              children: [
                Text(
                  'About FIT',
                  style: TextStyle(
                    fontSize: 26,
                    color: Colors.black,
                  ),
                ),
                SizedBox(
                  height: 20,
                ),
                FitHorizontalDivider(),
                SizedBox(
                  height: 20,
                ),
                Text(
                  """Faculty of Information Technology (FIT) is a member of the public \"Džemal Bijedić\" University of Mostar. It was founded in 1996 and had a two-year studying programme. In 2003, it was officially registered as the Faculty with a four-year studying programme. FIT organizes Bachelor (first cycle) and Master studies (second cycle) in the field of information technology.  Curriculum is realized in accordance with the principles of Bologna declaration. \n\nFirst cycle of studies is organized and realized in two ways: in-class and through Distance Learning (DL) system FIT is the institution that first introduced the distance learning concept of studying in Bosnia and Herzegovina and has a leading role in the process of implementing and developing distance learning in our country. The Faculty has four computer classrooms with more than one hundred computers, and four laboratories. Besides regular teaching activities, students and teaching staff have an opportunity to do research in the mentioned facilities.\n\nQuality and practical relevance of the studying programme are confirmed by the fact that 95% of ours students are employed. IT sector develops dynamically and there is a constant demand for IT professionals in Bosnia and Herzegovina and in the world. FIT does periodical evaluations in order to analyse whether the qualifications and skills to be gained according to the Curriculum respond to the needs and demands of the market and the environment. FIT has a very good cooperation with state, federal and cantonal ministries that work in the field of education and IT, as well as with the regional IT companies. \n\nFaculty also has a very good international cooperation, primarily with the universities in Austria (FH Joanneum, Graz), Germany (University in Paderborn) and Spain (University in Lleida) as well as with the universities in Bosnia and Herzegovina and the region. This cooperation includes realization of numerous activities like exchange of the teaching staff and students, realization of joint scientific-research projects, participation in seminars and conferences, realization of programmes for professional improvement, as well as other activities with the goal of intensifying academic cooperation. FIT participated in a great number of international projects and state-funded projects. Faculty makes continuous efforts to improve the quality of the activities related to the following: teaching process, Curriculum content, evaluation system, text-books and literature, equipment in classrooms and other facilities, DL platform, scientific and research activities, publishing activities, selection of teaching and administration staff, library-related activities, life-long learning and other standards.
                  """,
                  style: TextStyle(
                    fontSize: 16,
                    color: Colors.black,
                  ),
                ),
              ],
            ),
          ),
        ));
  }
}
