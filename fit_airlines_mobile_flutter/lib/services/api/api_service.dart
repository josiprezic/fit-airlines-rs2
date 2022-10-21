import 'dart:core';
import 'dart:convert';
import 'package:http/http.dart' as http;

class APIService {
  static String username = '';
  static String password = '';

  static String socketAddress = "172.25.208.1:25001";
  static String baseUrl = "http://" + socketAddress + "/api/";

  String get baseRouteUrl => baseUrl + route + '/';

  String get basicAuth => 'Basic ' + base64.encode(utf8.encode('$username:$password'));

  Map<String, String> get headers => {'authorization': basicAuth};

  String route;

  APIService({required this.route});

  Future<Map<String, dynamic>> getObject({required int id}) async {
    final response = await http.get(Uri.parse(baseRouteUrl), headers: headers);

    if (response.statusCode == 200) {
      final Map<String, dynamic> data = json.decode(response.body);
      return data;
    } else {
      // TODO: JR
      throw Exception('ERROR: STATUS CODE:' + response.statusCode.toString());
    }
  }

  Future<List<dynamic>> getObjectList({Map<String, dynamic> queryParams = const {}}) async {
    // print('DUPAra');
    // final queryParameters = {'loadPictures': true};
    // print('DUPAra 2');
    // // final uri = ;
    // print('DUPAra 3');
    // //print('URI: ' + uri.path);
    // //final response = await http.get(Uri.http('172.25.208.1:25001', '/api/offers/', queryParameters), headers: headers);
    // final response = await http.get(Uri.http(baseRouteUrl + '?loadPictures=true', ''), headers: headers);
    // if (response.statusCode == 200) {
    //   final List<dynamic> data = json.decode(response.body);
    //   print('HTTP RETURNED ' + data.length.toString() + ' objects.');
    //   return data;
    // } else {
    //   print('DUPA');
    //   // TODO: JR
    //   throw Exception('ERROR: STATUS CODE:' + response.statusCode.toString());
    // }

    print('PARAMS:' + queryParams.toString());

    var testPic = baseRouteUrl + '?loadPictures=true';

    //var finalRouteUrl = Uri.parse(baseRouteUrl).replace(queryParameters: queryParams);
    var workingFineUrl = Uri.parse(baseRouteUrl);
    print('BASE: ' + baseRouteUrl);
    //print('finalRouteUrl: ' + finalRouteUrl.toString());
    print('TEST: ' + testPic);

    final response = await http.get(Uri.parse(testPic), headers: headers);
    print(response.request.toString());
    if (response.statusCode == 200) {
      final List<dynamic> data = json.decode(response.body);
      print('HTTP RETURNED ' + data.length.toString() + ' objects.');
      return data;
    } else {
      // TODO: JR
      throw Exception('ERROR: STATUS CODE:' + response.statusCode.toString());
    }
  }
}
