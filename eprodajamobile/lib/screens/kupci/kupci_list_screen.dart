import 'package:eprodajamobile/providers/kupci_provider.dart';
import 'package:eprodajamobile/screens/cart/cart_screen.dart';
import 'package:eprodajamobile/utils/util.dart';
import 'package:eprodajamobile/widgets/master_screen.dart';
import 'package:flutter/material.dart';
import 'package:flutter/rendering.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';

import '../../model/kupci.dart';
import '../../providers/cart_provider.dart';
import '../../widgets/eprodaja_drawer.dart';

class KupciListScreen extends StatefulWidget {
  static const String routeName = "/kupci";

  const KupciListScreen({Key? key}) : super(key: key);

  @override
  State<KupciListScreen> createState() => _KupciListScreenState();
}

class _KupciListScreenState extends State<KupciListScreen> {
  KupciProvider? _kupciProvider = null;
  CartProvider? _cartProvider = null;
  List<Kupci> data = [];
  TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _kupciProvider = context.read<KupciProvider>();
    _cartProvider = context.read<CartProvider>();
    print("called initState");
    loadData();
  }

  Future loadData() async {
    var tmpData = await _kupciProvider?.get(null);
    setState(() {
      data = tmpData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    print("called build $data");
    return MasterScreenWidget(
      child: SingleChildScrollView(
        child: Container(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              _buildHeader(),
              _buildKupciSearch(),
              Container(
                height: 200,
                child: GridView(
                  gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                      crossAxisCount: 1,
                      childAspectRatio: 4 / 3,
                      crossAxisSpacing: 20,
                      mainAxisSpacing: 30),
                  scrollDirection: Axis.vertical,
                  children: _buildKupciCardList(),
                ),
              )
            ],
          ),
        ),
      )
    );
  }

  Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text("Kupci", style: TextStyle(color: Colors.grey, fontSize: 40, fontWeight: FontWeight.w600),),
    );
  }

  Widget _buildKupciSearch() {
    return Row(
      children: [
        Expanded(
          child: Container(
            padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
            child: TextField(
              controller: _searchController,
              onSubmitted: (value) async {
                var tmpData = await _kupciProvider?.get({'ime': value});
                setState(() {
                  data = tmpData!;
                });
              },
              decoration: InputDecoration(
                  hintText: "Search",
                  prefixIcon: Icon(Icons.search),
                  border: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(10),
                      borderSide: BorderSide(color: Colors.grey))),
            ),
          ),
        ),
        Container(
          padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
          child: IconButton(
            icon: Icon(Icons.filter_list),
            onPressed: () async {
                var tmpData = await _kupciProvider?.get({'ime': _searchController.text});
                setState(() {
                  data = tmpData!;
                });
            },
          ),
        )
      ],
    );
  }


  List<Widget> _buildKupciCardList() {
    if (data.length == 0) {
      return [Text("Loading...")];
    }

    List<Widget> list = data
        .map((x) => Container(
              
              child: Column(
                children: [
                  
                  Text(x.ime ?? ""),
                  Text(x.prezime ?? ""),
                  Text(x.email ?? "")
                ],
              ),
            ))
        .cast<Widget>()
        .toList();

    return list;
  }
}
