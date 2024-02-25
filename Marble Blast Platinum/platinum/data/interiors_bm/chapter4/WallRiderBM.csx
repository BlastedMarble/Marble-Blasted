<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/02/17 21:23:54">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="721">
                    <Brush id="0" owner="0" type="0" pos="5 -5 0.25" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -5 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 0.25" />
                            <Vertex pos="6 6 -0.25" />
                            <Vertex pos="6 -6 0.25" />
                            <Vertex pos="6 -6 -0.25" />
                            <Vertex pos="-6 6 0.25" />
                            <Vertex pos="-6 6 -0.25" />
                            <Vertex pos="-6 -6 0.25" />
                            <Vertex pos="-6 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="2 4 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 4 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 3 -0.5" />
                            <Vertex pos="9 3 -1" />
                            <Vertex pos="9 -3 1" />
                            <Vertex pos="9 -3 0.5" />
                            <Vertex pos="-9 3 -0.5" />
                            <Vertex pos="-9 3 -1" />
                            <Vertex pos="-3 -3 1" />
                            <Vertex pos="-3 -3 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -9" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -4.24264" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 -896 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="-4 -2 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -2 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 1" />
                            <Vertex pos="3 3 0.5" />
                            <Vertex pos="3 -9 1" />
                            <Vertex pos="3 -9 0.5" />
                            <Vertex pos="-3 9 -0.5" />
                            <Vertex pos="-3 9 -1" />
                            <Vertex pos="-3 -9 -0.5" />
                            <Vertex pos="-3 -9 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.24264" album="" material="bm_edge_white" texgens="-1 0 0 -2176 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_edge_white" texgens="1 0 0 2304 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 -128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -896 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-13 67 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 67 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="26 4 -0.749998" />
                            <Vertex pos="26 4 -1.25" />
                            <Vertex pos="26 -4 1.25" />
                            <Vertex pos="26 -4 0.750002" />
                            <Vertex pos="-26 4 -0.749998" />
                            <Vertex pos="-26 4 -1.25" />
                            <Vertex pos="-18 -4 1.25" />
                            <Vertex pos="-18 -4 0.750002" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -26" album="" material="bm_edge_white" texgens="0 1 0 -1920 0 0 -1 320.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -15.5563" album="" material="bm_edge_white" texgens="0 -1 0 2048 0 0 -1 320.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 3200 0 0 -1 320.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -3072 0 0 -1 320.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242535 0.970143 -0.242537" album="" material="bm_grid_blank2" texgens="1 0 0 -2816 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -0.242535" album="" material="bm_grid_blank1" texgens="-1 0 0 1792 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-30 -19 -4" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 -19 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 8 7" />
                            <Vertex pos="1 8 1" />
                            <Vertex pos="1 -8 7" />
                            <Vertex pos="1 -8 1" />
                            <Vertex pos="-1 8 7" />
                            <Vertex pos="-1 8 1" />
                            <Vertex pos="-1 -8 7" />
                            <Vertex pos="-1 -8 1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 1024 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_tile04_C" texgens="0 -1 0 -1536 0 0 -1 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-65 -26 -4" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 -26 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="34 1 7" />
                            <Vertex pos="34 1 1" />
                            <Vertex pos="34 -1 7" />
                            <Vertex pos="34 -1 1" />
                            <Vertex pos="-34 1 7" />
                            <Vertex pos="-34 1 1" />
                            <Vertex pos="-34 -1 7" />
                            <Vertex pos="-34 -1 1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -34" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -34" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_tile04_C" texgens="-1 0 0 -8192 0 0 -1 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -4096 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank1" texgens="1 0 0 -4096 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1" album="" material="bm_grid_blank1" texgens="-1 0 0 4352 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-100 -19 -4" rot="1 0 0 0" scale="" transform="1 0 0 -100 0 1 0 -19 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 8 7" />
                            <Vertex pos="1 8 1" />
                            <Vertex pos="1 -8 7" />
                            <Vertex pos="1 -8 1" />
                            <Vertex pos="-1 8 7" />
                            <Vertex pos="-1 8 1" />
                            <Vertex pos="-1 -8 7" />
                            <Vertex pos="-1 -8 1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_tile04_C" texgens="0 1 0 -1536 0 0 -1 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -768 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-38 -17 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 -38 0 1 0 -17 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 2 1.25" />
                            <Vertex pos="7 2 0.75" />
                            <Vertex pos="7 -2 -0.75" />
                            <Vertex pos="7 -2 -1.25" />
                            <Vertex pos="-7 2 1.25" />
                            <Vertex pos="-7 2 0.75" />
                            <Vertex pos="-7 -2 -0.75" />
                            <Vertex pos="-7 -2 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_edge_white" texgens="0 1 0 -3968 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -7" album="" material="bm_edge_white" texgens="0 -1 0 4096 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2944 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2816 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223607" album="" material="bm_friction_sand" texgens="1 0 0 -2816 0 -1 0 4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="" material="bm_grid_blank1" texgens="-1 0 0 1664 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-65 -17 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 -17 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 2 1.25" />
                            <Vertex pos="8 2 0.75" />
                            <Vertex pos="8 -2 -0.75" />
                            <Vertex pos="8 -2 -1.25" />
                            <Vertex pos="-8 2 1.25" />
                            <Vertex pos="-8 2 0.75" />
                            <Vertex pos="-8 -2 -0.75" />
                            <Vertex pos="-8 -2 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 -3968 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 4096 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2688 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2560 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223607" album="" material="bm_friction_sand" texgens="1 0 0 -2560 0 -1 0 4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="" material="bm_grid_blank1" texgens="-1 0 0 1536 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="-92 -17 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 -92 0 1 0 -17 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 2 1.25" />
                            <Vertex pos="7 2 0.75" />
                            <Vertex pos="7 -2 -0.75" />
                            <Vertex pos="7 -2 -1.25" />
                            <Vertex pos="-7 2 1.25" />
                            <Vertex pos="-7 2 0.75" />
                            <Vertex pos="-7 -2 -0.75" />
                            <Vertex pos="-7 -2 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_edge_white" texgens="0 1 0 -3968 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -7" album="" material="bm_edge_white" texgens="0 -1 0 4096 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2944 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2816 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223607" album="" material="bm_friction_sand" texgens="1 0 0 -2816 0 -1 0 4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="" material="bm_grid_blank1" texgens="-1 0 0 1664 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="12 95 -5" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 95 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 8 6" />
                            <Vertex pos="1 8 0" />
                            <Vertex pos="1 -8 6" />
                            <Vertex pos="1 -8 0" />
                            <Vertex pos="-1 8 6" />
                            <Vertex pos="-1 8 0" />
                            <Vertex pos="-1 -8 6" />
                            <Vertex pos="-1 -8 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_tile04_C" texgens="0 -1 0 -1536 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="1 102 -5" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 102 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 1 6" />
                            <Vertex pos="10 1 0" />
                            <Vertex pos="10 -1 6" />
                            <Vertex pos="10 -1 0" />
                            <Vertex pos="-10 1 6" />
                            <Vertex pos="-10 1 0" />
                            <Vertex pos="-10 -1 6" />
                            <Vertex pos="-10 -1 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_tile04_C" texgens="1 0 0 -2048 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_grid_blank1" texgens="1 0 0 -1024 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-10 95 -5" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 95 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 8 6" />
                            <Vertex pos="1 8 0" />
                            <Vertex pos="1 -8 6" />
                            <Vertex pos="1 -8 0" />
                            <Vertex pos="-1 8 6" />
                            <Vertex pos="-1 8 0" />
                            <Vertex pos="-1 -8 6" />
                            <Vertex pos="-1 -8 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_tile04_C" texgens="0 1 0 -1536 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -768 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank1" texgens="-1 0 0 -6016 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank1" texgens="1 0 0 6272 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_grid_blank1" texgens="1 0 0 6272 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0" album="" material="bm_grid_blank1" texgens="-1 0 0 -6016 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="-66 5 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 -66 0 1 0 5 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="27 4 -0.75" />
                            <Vertex pos="27 4 -1.25" />
                            <Vertex pos="35 -4 1.25" />
                            <Vertex pos="35 -4 0.75" />
                            <Vertex pos="-35 4 -0.75" />
                            <Vertex pos="-35 4 -1.25" />
                            <Vertex pos="-35 -4 1.25" />
                            <Vertex pos="-35 -4 0.75" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -21.9203" album="" material="bm_edge_white" texgens="0 1 0 -3456 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -35" album="" material="bm_edge_white" texgens="0 -1 0 3584 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 10624 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -10496 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 -4224 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 5504 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-97 33.75 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 33.75 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6.75 0.25" />
                            <Vertex pos="2 6.75 -0.25" />
                            <Vertex pos="2 -6.75 0.25" />
                            <Vertex pos="2 -6.75 -0.25" />
                            <Vertex pos="-2 6.75 0.25" />
                            <Vertex pos="-2 6.75 -0.25" />
                            <Vertex pos="-2 -6.75 0.25" />
                            <Vertex pos="-2 -6.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 -608 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -608 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.75" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.75" album="" material="bm_edge_white" texgens="1 0 0 2560 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_C" texgens="1 0 0 2560 0 -1 0 1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1024 0 -1 0 672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-100 33 -2.99999" rot="1 0 0 0" scale="" transform="1 0 0 -100 0 1 0 33 0 0 1 -2.99999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 0.500009" />
                            <Vertex pos="1 6 7.15256e-007" />
                            <Vertex pos="1 -5.99994 0.50001" />
                            <Vertex pos="1 -5.99992 2.6226e-006" />
                            <Vertex pos="-1 8 -4.76837e-007" />
                            <Vertex pos="-1 8 -0.50001" />
                            <Vertex pos="-1 -8 9.53674e-007" />
                            <Vertex pos="-1 -7.99998 -0.500007" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 0.00402832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 0.00402832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.94975" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0.00402832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707121 -0.707093 -2.83217e-005 -4.94962" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0.00402832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.24254 8.67374e-008 0.970141 -0.24254" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.24254 -1.542e-007 -0.970141 -0.242538" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="-94 33 -3" rot="1 0 0 0" scale="" transform="1 0 0 -94 0 1 0 33 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 8 9.53674e-007" />
                            <Vertex pos="1 8 -0.500001" />
                            <Vertex pos="1 -8 9.53674e-007" />
                            <Vertex pos="1 -8 -0.500001" />
                            <Vertex pos="-1 6 0.500001" />
                            <Vertex pos="-1 6 -4.05312e-006" />
                            <Vertex pos="-1 -6 0.500001" />
                            <Vertex pos="-1 -6 -4.05312e-006" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -4.94975" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -4.94975" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242537" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242534 0 -0.970143 -0.242538" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-97 26 -3" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 26 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.99999 1 0.5" />
                            <Vertex pos="1.99999 1 2.38419e-007" />
                            <Vertex pos="3.99999 -1 -2.38419e-007" />
                            <Vertex pos="3.99999 -1 -0.5" />
                            <Vertex pos="-1.99999 1 0.5" />
                            <Vertex pos="-1.99999 1 2.38419e-007" />
                            <Vertex pos="-3.99999 -1 -2.38419e-007" />
                            <Vertex pos="-3.99999 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.12131" album="" material="bm_edge_white" texgens="0 1 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.12131" album="" material="bm_edge_white" texgens="0 -1 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 -0.242535" album="" material="bm_grid_blank1" texgens="-1 0 0 -1024 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-97 40 -3" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 40 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.00001 1 -4.76837e-007" />
                            <Vertex pos="4.00001 1 -0.5" />
                            <Vertex pos="2.00001 -1 0.5" />
                            <Vertex pos="2.00001 -1 0" />
                            <Vertex pos="-4.00001 1 -4.76837e-007" />
                            <Vertex pos="-4.00001 1 -0.5" />
                            <Vertex pos="-2.00001 -1 0.5" />
                            <Vertex pos="-2.00001 -1 0" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.12133" album="" material="bm_edge_white" texgens="0 1 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.12133" album="" material="bm_edge_white" texgens="0 -1 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1024 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-108 15 -1" rot="1 0 0 0" scale="" transform="1 0 0 -108 0 1 0 15 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 10" />
                            <Vertex pos="3 2 -10" />
                            <Vertex pos="3 -2 10" />
                            <Vertex pos="3 -2 -10" />
                            <Vertex pos="-3 2 10" />
                            <Vertex pos="-3 2 -10" />
                            <Vertex pos="-3 -2 10" />
                            <Vertex pos="-3 -2 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank1" texgens="0 1 0 3328 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank1" texgens="0 -1 0 -3072 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 640 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -384 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 -384 0 -1 0 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 640 0 -1 0 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-109 35 -1" rot="1 0 0 0" scale="" transform="1 0 0 -109 0 1 0 35 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 18 10" />
                            <Vertex pos="2 18 -10" />
                            <Vertex pos="2 -18 10" />
                            <Vertex pos="2 -18 -10" />
                            <Vertex pos="-2 18 10" />
                            <Vertex pos="-2 18 -10" />
                            <Vertex pos="-2 -18 10" />
                            <Vertex pos="-2 -18 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 2304 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -2048 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -18" album="" material="bm_grid_blank1" texgens="-1 0 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -18" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 256 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="21.75 25 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 21.75 0 1 0 25 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.75 2 0.25" />
                            <Vertex pos="6.75 2 -0.25" />
                            <Vertex pos="6.75 -2 0.25" />
                            <Vertex pos="6.75 -2 -0.25" />
                            <Vertex pos="-6.75 2 0.25" />
                            <Vertex pos="-6.75 2 -0.25" />
                            <Vertex pos="-6.75 -2 0.25" />
                            <Vertex pos="-6.75 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.75" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.75" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -608 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 864 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_C" texgens="1 0 0 3776 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1632 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="14 25 -1" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 25 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.5" />
                            <Vertex pos="1 2 -5.96046e-008" />
                            <Vertex pos="1 -2 0.5" />
                            <Vertex pos="1 -2 -5.96046e-008" />
                            <Vertex pos="-1 4 5.96046e-008" />
                            <Vertex pos="-1 4 -0.5" />
                            <Vertex pos="-1 -4 5.96046e-008" />
                            <Vertex pos="-1 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="28 25 -1" rot="1 0 0 0" scale="" transform="1 0 0 28 0 1 0 25 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 5.96046e-008" />
                            <Vertex pos="1 4 -0.5" />
                            <Vertex pos="1 -4 5.96046e-008" />
                            <Vertex pos="1 -4 -0.5" />
                            <Vertex pos="-1 2 0.5" />
                            <Vertex pos="-1 2 -5.96046e-008" />
                            <Vertex pos="-1 -2 0.5" />
                            <Vertex pos="-1 -2 -5.96046e-008" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 -4736 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.12132" album="" material="bm_edge_white" texgens="1 0 0 4864 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 1152 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -2176 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="21 22 -1" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 22 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 0.500001" />
                            <Vertex pos="6 1 -8.34465e-007" />
                            <Vertex pos="8 -1 7.15256e-007" />
                            <Vertex pos="8 -1 -0.500001" />
                            <Vertex pos="-6 1 0.500001" />
                            <Vertex pos="-6 1 -8.34465e-007" />
                            <Vertex pos="-8 -1 7.15256e-007" />
                            <Vertex pos="-8 -1 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -4.94975" album="" material="bm_edge_white" texgens="0 1 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -4.94975" album="" material="bm_edge_white" texgens="0 -1 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 512 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242537" album="" material="bm_grid_blank1" texgens="-1 0 0 -1536 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="21 28 -1" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 28 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 4.17233e-007" />
                            <Vertex pos="8 1 -0.5" />
                            <Vertex pos="6 -1 0.5" />
                            <Vertex pos="6 -1 0" />
                            <Vertex pos="-8 1 4.17233e-007" />
                            <Vertex pos="-8 1 -0.5" />
                            <Vertex pos="-6 -1 0.5" />
                            <Vertex pos="-6 -1 0" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -4.94975" album="" material="bm_edge_white" texgens="0 1 0 -4736 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -4.94975" album="" material="bm_edge_white" texgens="0 -1 0 4864 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242535 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 512 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1536 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="21.75 37 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 21.75 0 1 0 37 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.75 2 0.25" />
                            <Vertex pos="6.75 2 -0.25" />
                            <Vertex pos="6.75 -2 0.25" />
                            <Vertex pos="6.75 -2 -0.25" />
                            <Vertex pos="-6.75 2 0.25" />
                            <Vertex pos="-6.75 2 -0.25" />
                            <Vertex pos="-6.75 -2 0.25" />
                            <Vertex pos="-6.75 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.75" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.75" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -608 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 864 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_C" texgens="1 0 0 3776 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1632 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="14 37 -1" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 37 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.5" />
                            <Vertex pos="1 2 -5.96046e-008" />
                            <Vertex pos="1 -1.99999 0.5" />
                            <Vertex pos="1 -1.99999 -5.96046e-008" />
                            <Vertex pos="-1 4 5.96046e-008" />
                            <Vertex pos="-1 4 -0.5" />
                            <Vertex pos="-1 -3.99999 5.96046e-008" />
                            <Vertex pos="-1 -3.99999 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.12131" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="28 37 -1" rot="1 0 0 0" scale="" transform="1 0 0 28 0 1 0 37 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 5.96046e-008" />
                            <Vertex pos="1 4 -0.5" />
                            <Vertex pos="1 -4 5.96046e-008" />
                            <Vertex pos="1 -4 -0.5" />
                            <Vertex pos="-1 2 0.5" />
                            <Vertex pos="-1 2 -5.96046e-008" />
                            <Vertex pos="-1 -2 0.5" />
                            <Vertex pos="-1 -2 -5.96046e-008" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 -4736 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.12132" album="" material="bm_edge_white" texgens="1 0 0 4864 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 1152 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -2176 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="21 34 -1" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 34 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 0.5" />
                            <Vertex pos="6 1 -5.96046e-007" />
                            <Vertex pos="8 -1 4.76837e-007" />
                            <Vertex pos="8 -1 -0.5" />
                            <Vertex pos="-6 1 0.5" />
                            <Vertex pos="-6 1 -5.96046e-007" />
                            <Vertex pos="-8 -1 4.76837e-007" />
                            <Vertex pos="-8 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -4.94975" album="" material="bm_edge_white" texgens="0 1 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -4.94975" album="" material="bm_edge_white" texgens="0 -1 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242535 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 512 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242535 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1536 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="21 40 -1" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 40 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 1.43051e-006" />
                            <Vertex pos="8.00001 1 -0.500001" />
                            <Vertex pos="6 -1 0.500001" />
                            <Vertex pos="6 -1 -4.76837e-007" />
                            <Vertex pos="-8 1 1.43051e-006" />
                            <Vertex pos="-8 1 -0.500001" />
                            <Vertex pos="-6 -1 0.500001" />
                            <Vertex pos="-6 -1 -4.76837e-007" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -4.94975" album="" material="bm_edge_white" texgens="0 1 0 -4736 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -4.94975" album="" material="bm_edge_white" texgens="0 -1 0 4864 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242535 0.970143 -0.242537" album="" material="bm_grid_blank2" texgens="1 0 0 512 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1536 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="-13 28.75 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 28.75 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 5.75 0.25" />
                            <Vertex pos="2 5.75 -0.25" />
                            <Vertex pos="2 -5.75 0.25" />
                            <Vertex pos="2 -5.75 -0.25" />
                            <Vertex pos="-2 5.75 0.25" />
                            <Vertex pos="-2 5.75 -0.25" />
                            <Vertex pos="-2 -5.75 0.25" />
                            <Vertex pos="-2 -5.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 736 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1088 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5.75" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.75" album="" material="bm_edge_white" texgens="1 0 0 2560 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_C" texgens="1 0 0 2560 0 -1 0 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1024 0 -1 0 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="-16 28 -1" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 28 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 0" />
                            <Vertex pos="1 -5 0.5" />
                            <Vertex pos="1 -5 5.96046e-008" />
                            <Vertex pos="-1 1 -1.19209e-007" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 -7 -1.19209e-007" />
                            <Vertex pos="-1 -7 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1152 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1280 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -4.24264" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 -7.22812e-009 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="-10 28 -1" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 28 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 7 2.38419e-007" />
                            <Vertex pos="1 7 -0.5" />
                            <Vertex pos="1 -7 2.38419e-007" />
                            <Vertex pos="1 -7 -0.5" />
                            <Vertex pos="-1 5 0.5" />
                            <Vertex pos="-1 5 -2.38419e-007" />
                            <Vertex pos="-1 -5 0.5" />
                            <Vertex pos="-1 -5 -2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1152 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1280 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -4.24264" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -4.24264" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-13 22 -1" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 22 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.5" />
                            <Vertex pos="2 1 -2.38419e-007" />
                            <Vertex pos="4 -1 2.38419e-007" />
                            <Vertex pos="4 -1 -0.5" />
                            <Vertex pos="-2 1 0.5" />
                            <Vertex pos="-2 1 -2.38419e-007" />
                            <Vertex pos="-4 -1 2.38419e-007" />
                            <Vertex pos="-4 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1024 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="-9 34 -0.999999" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 34 0 0 1 -0.999999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 1 0" />
                            <Vertex pos="0 1 -0.5" />
                            <Vertex pos="-2 -1 0.5" />
                            <Vertex pos="-2 -1 0" />
                            <Vertex pos="-4 1 0" />
                            <Vertex pos="-4 1 -0.5" />
                            <Vertex pos="-6 -1 0.499999" />
                            <Vertex pos="-6 -1 -1.01328e-006" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 0.707107" album="" material="bm_edge_white" texgens="0 1 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.53553" album="" material="bm_edge_white" texgens="0 -1 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242535 0.970143 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="2.45756e-007 -0.242536 -0.970142 -0.242535" album="" material="bm_grid_blank1" texgens="-1 0 0 -1024 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="-85 51 -1" rot="1 0 0 0" scale="" transform="1 0 0 -85 0 1 0 51 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="22 2 10" />
                            <Vertex pos="22 2 -10" />
                            <Vertex pos="22 -2 10" />
                            <Vertex pos="22 -2 -10" />
                            <Vertex pos="-22 2 10" />
                            <Vertex pos="-22 2 -10" />
                            <Vertex pos="-22 -2 10" />
                            <Vertex pos="-22 -2 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -22" album="" material="bm_grid_blank1" texgens="0 1 0 3584 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -22" album="" material="bm_grid_blank1" texgens="0 -1 0 -3328 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -1792 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 2048 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 2048 0 -1 0 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 -1792 0 -1 0 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="-17 35.25 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 35.25 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 5.75 0.25" />
                            <Vertex pos="2 5.75 -0.25" />
                            <Vertex pos="2 -5.75 0.25" />
                            <Vertex pos="2 -5.75 -0.25" />
                            <Vertex pos="-2 5.75 0.25" />
                            <Vertex pos="-2 5.75 -0.25" />
                            <Vertex pos="-2 -5.75 0.25" />
                            <Vertex pos="-2 -5.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1856 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -544 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5.75" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.75" album="" material="bm_edge_white" texgens="1 0 0 2560 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_C" texgens="1 0 0 2560 0 -1 0 1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1024 0 -1 0 992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="-20 36 -1" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 36 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 5 0.5" />
                            <Vertex pos="1 5 1.19209e-007" />
                            <Vertex pos="1 -5 0.5" />
                            <Vertex pos="1 -5 1.19209e-007" />
                            <Vertex pos="-1 7 -1.19209e-007" />
                            <Vertex pos="-1 7 -0.5" />
                            <Vertex pos="-1 -7 -1.19209e-007" />
                            <Vertex pos="-1 -7 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.24264" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -4.24264" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="-14 40 -1" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 40 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 3.57628e-007" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -5 0" />
                            <Vertex pos="1 -5 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="-1 1 -4.76837e-007" />
                            <Vertex pos="-1 -7 0.5" />
                            <Vertex pos="-1 -7 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -4.24264" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242535 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="-17 30 -1" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 30 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.5" />
                            <Vertex pos="2 1 0" />
                            <Vertex pos="0 -1 0" />
                            <Vertex pos="0 -1 -0.5" />
                            <Vertex pos="-2 1 0.5" />
                            <Vertex pos="-2 1 0" />
                            <Vertex pos="-4 -1 0" />
                            <Vertex pos="-4 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.707107" album="" material="bm_edge_white" texgens="0 1 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 -1 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1024 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="-17 42 -0.999999" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 42 0 0 1 -0.999999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 0" />
                            <Vertex pos="4 1 -0.5" />
                            <Vertex pos="2 -1 0.5" />
                            <Vertex pos="2 -1 0" />
                            <Vertex pos="-4 1 0" />
                            <Vertex pos="-4 1 -0.5" />
                            <Vertex pos="-2 -1 0.5" />
                            <Vertex pos="-2 -1 0" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1024 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="-7 -13 -1" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -13 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="22 2 10" />
                            <Vertex pos="22 2 -10" />
                            <Vertex pos="22 -2 10" />
                            <Vertex pos="22 -2 -10" />
                            <Vertex pos="-22 2 10" />
                            <Vertex pos="-22 2 -10" />
                            <Vertex pos="-22 -2 10" />
                            <Vertex pos="-22 -2 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -22" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -22" album="" material="bm_grid_blank1" texgens="0 -1 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 5888 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -5632 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 -5632 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 5888 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="13 2 -1" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 2 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 13 10" />
                            <Vertex pos="2 13 -10" />
                            <Vertex pos="2 -13 10" />
                            <Vertex pos="2 -13 -10" />
                            <Vertex pos="-2 13 10" />
                            <Vertex pos="-2 13 -10" />
                            <Vertex pos="-2 -13 10" />
                            <Vertex pos="-2 -13 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 1920 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -1664 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -13" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -13" album="" material="bm_grid_blank1" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 256 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="25 13 -1" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 13 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 2 10" />
                            <Vertex pos="10 2 -10" />
                            <Vertex pos="10 -2 10" />
                            <Vertex pos="10 -2 -10" />
                            <Vertex pos="-10 2 10" />
                            <Vertex pos="-10 2 -10" />
                            <Vertex pos="-10 -2 10" />
                            <Vertex pos="-10 -2 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank1" texgens="0 1 0 3328 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank1" texgens="0 -1 0 -3072 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -1280 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 1536 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 1536 0 -1 0 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 -1280 0 -1 0 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="26 49 -1" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 49 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 2 10" />
                            <Vertex pos="9 2 -10" />
                            <Vertex pos="9 -2 10" />
                            <Vertex pos="9 -2 -10" />
                            <Vertex pos="-9 2 10" />
                            <Vertex pos="-9 2 -10" />
                            <Vertex pos="-9 -2 10" />
                            <Vertex pos="-9 -2 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_grid_blank1" texgens="0 1 0 3584 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank1" texgens="0 -1 0 -3328 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -1408 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 1664 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 1664 0 -1 0 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 -1408 0 -1 0 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="37 31 -1" rot="1 0 0 0" scale="" transform="1 0 0 37 0 1 0 31 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 20 10" />
                            <Vertex pos="2 20 -10" />
                            <Vertex pos="2 -20 10" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="-2 20 10" />
                            <Vertex pos="-2 20 -10" />
                            <Vertex pos="-2 -20 10" />
                            <Vertex pos="-2 -20 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 2304 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -2048 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -20" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -20" album="" material="bm_grid_blank1" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 256 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="-35 36 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 36 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 27 1.25" />
                            <Vertex pos="4 27 0.75" />
                            <Vertex pos="4 -35 1.25" />
                            <Vertex pos="4 -35 0.75" />
                            <Vertex pos="-4 35 -0.75" />
                            <Vertex pos="-4 35 -1.25" />
                            <Vertex pos="-4 -27 -0.75" />
                            <Vertex pos="-4 -27 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 4480 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -4352 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -21.9203" album="" material="bm_edge_white" texgens="-1 0 0 2688 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -21.9203" album="" material="bm_edge_white" texgens="1 0 0 -2560 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 1536 0 -1 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="-51.75 79 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -51.75 0 1 0 79 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.75 2 0.25" />
                            <Vertex pos="6.75 2 -0.25" />
                            <Vertex pos="6.75 -2 0.25" />
                            <Vertex pos="6.75 -2 -0.25" />
                            <Vertex pos="-6.75 2 0.25" />
                            <Vertex pos="-6.75 2 -0.25" />
                            <Vertex pos="-6.75 -2 0.25" />
                            <Vertex pos="-6.75 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.75" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.75" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 864 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -608 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_C" texgens="1 0 0 3392 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1440 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="-58 79 -3" rot="1 0 0 0" scale="" transform="1 0 0 -58 0 1 0 79 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.00002 0.5" />
                            <Vertex pos="1 2.00002 -2.38419e-007" />
                            <Vertex pos="1 -2.00001 0.5" />
                            <Vertex pos="1 -2.00001 -2.38419e-007" />
                            <Vertex pos="-1 4.00002 2.38419e-007" />
                            <Vertex pos="-1 4.00002 -0.5" />
                            <Vertex pos="-1 -4.00001 2.38419e-007" />
                            <Vertex pos="-1 -4.00001 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -2.12133" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.12133" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="-44 79 -3" rot="1 0 0 0" scale="" transform="1 0 0 -44 0 1 0 79 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3.99999 -4.76837e-007" />
                            <Vertex pos="1 3.99999 -0.5" />
                            <Vertex pos="1 -3.99999 -4.76837e-007" />
                            <Vertex pos="1 -3.99999 -0.5" />
                            <Vertex pos="-1 1.99999 0.5" />
                            <Vertex pos="-1 1.99999 4.76837e-007" />
                            <Vertex pos="-1 -1.99999 0.5" />
                            <Vertex pos="-1 -1.99999 4.76837e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.12131" album="" material="bm_edge_white" texgens="-1 0 0 -4736 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.12131" album="" material="bm_edge_white" texgens="1 0 0 4864 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 1152 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.242535" album="" material="bm_grid_blank1" texgens="-1 0 0 -2176 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="-51 76 -3" rot="1 0 0 0" scale="" transform="1 0 0 -51 0 1 0 76 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.99999 1 0.500001" />
                            <Vertex pos="5.99999 1 -9.53674e-007" />
                            <Vertex pos="7.99999 -1 1.19209e-006" />
                            <Vertex pos="7.99999 -1 -0.500001" />
                            <Vertex pos="-5.99999 1 0.500001" />
                            <Vertex pos="-6 1 -9.53674e-007" />
                            <Vertex pos="-7.99999 -1 1.19209e-006" />
                            <Vertex pos="-7.99999 -1 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -4.94974" album="" material="bm_edge_white" texgens="0 1 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.70711 0.707103 1.41614e-005 -4.94977" album="" material="bm_edge_white" texgens="0 -1 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -0.242537" album="" material="bm_grid_blank2" texgens="1 0 0 512 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 -0.242537" album="" material="bm_grid_blank1" texgens="-1 0 0 -1536 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="-51 82 -3" rot="1 0 0 0" scale="" transform="1 0 0 -51 0 1 0 82 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 -5.00679e-006" />
                            <Vertex pos="8 1 -0.500005" />
                            <Vertex pos="6 -1 0.500005" />
                            <Vertex pos="6 -1 5.00679e-006" />
                            <Vertex pos="-7.99999 1 -5.00679e-006" />
                            <Vertex pos="-7.99999 1 -0.500005" />
                            <Vertex pos="-6 -1 0.500005" />
                            <Vertex pos="-6 -1 5.00679e-006" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -4.94975" album="" material="bm_edge_white" texgens="0 1 0 -4736 0 0 -1 0.00299072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707108 -0.707105 0 -4.94976" album="" material="bm_edge_white" texgens="0 -1 0 4864 0 0 -1 0.00299072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -3456 0 0 -1 0.00299072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 3584 0 0 -1 0.00299072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.24254 0.970141 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 512 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.24254 -0.970141 -0.242535" album="" material="bm_grid_blank1" texgens="-1 0 0 -1536 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="-65 25 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 25 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="13.5 2 0.25" />
                            <Vertex pos="13.5 2 -0.25" />
                            <Vertex pos="13.5 -2 0.25" />
                            <Vertex pos="13.5 -2 -0.25" />
                            <Vertex pos="-13.5 2 0.25" />
                            <Vertex pos="-13.5 2 -0.25" />
                            <Vertex pos="-13.5 -2 0.25" />
                            <Vertex pos="-13.5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -13.5" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -13.5" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 8448 0 0 -1 -288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -8192 0 0 -1 -288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_C" texgens="1 0 0 2048 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -768 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="-78 25 -3" rot="1 0 0 0" scale="" transform="1 0 0 -78 0 1 0 25 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.5" />
                            <Vertex pos="1 2 -2.38419e-007" />
                            <Vertex pos="1 -2 0.5" />
                            <Vertex pos="1 -2 -2.38419e-007" />
                            <Vertex pos="-1 4 2.38419e-007" />
                            <Vertex pos="-1 4 -0.5" />
                            <Vertex pos="-1 -4 2.38419e-007" />
                            <Vertex pos="-1 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 -1408 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="-52 24.9999 -3" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 24.9999 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3.99994 -1.19209e-006" />
                            <Vertex pos="1 3.99994 -0.499999" />
                            <Vertex pos="1 -3.99994 -1.19209e-006" />
                            <Vertex pos="1 -3.99994 -0.499999" />
                            <Vertex pos="-1 1.99994 0.499999" />
                            <Vertex pos="-1 1.99994 9.53674e-007" />
                            <Vertex pos="-1 -1.99994 0.499999" />
                            <Vertex pos="-1 -1.99994 9.53674e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2431.98 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2559.98 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.12128" album="" material="bm_edge_white" texgens="-1 0 0 -4736 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.12128" album="" material="bm_edge_white" texgens="1 0 0 4864 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 1152 0 -1 0 1280.01 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242535" album="" material="bm_grid_blank1" texgens="-1 0 0 -2176 0 -1 0 1280.01 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="-65 22 -3" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 22 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 1 0.499999" />
                            <Vertex pos="12 1 2.38419e-007" />
                            <Vertex pos="14 -1 -7.15256e-007" />
                            <Vertex pos="14 -1 -0.5" />
                            <Vertex pos="-12 1 0.499999" />
                            <Vertex pos="-12 1 2.38419e-007" />
                            <Vertex pos="-14 -1 -7.15256e-007" />
                            <Vertex pos="-14 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -9.19239" album="" material="bm_edge_white" texgens="0 1 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -9.19239" album="" material="bm_edge_white" texgens="0 -1 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242535 0.970143 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -768 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="-65 28 -3" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 28 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14 1 -2.38419e-007" />
                            <Vertex pos="14 1 -0.5" />
                            <Vertex pos="12 -1 0.5" />
                            <Vertex pos="12 -1 2.38419e-007" />
                            <Vertex pos="-14 1 -2.38419e-007" />
                            <Vertex pos="-14 1 -0.5" />
                            <Vertex pos="-12 -1 0.5" />
                            <Vertex pos="-12 -1 2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -9.19239" album="" material="bm_edge_white" texgens="0 1 0 -4736 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -9.19239" album="" material="bm_edge_white" texgens="0 -1 0 4864 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -768 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="-65 72 -1" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 72 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 19 10" />
                            <Vertex pos="2 19 -10" />
                            <Vertex pos="2 -19 10" />
                            <Vertex pos="2 -19 -10" />
                            <Vertex pos="-2 19 10" />
                            <Vertex pos="-2 19 -10" />
                            <Vertex pos="-2 -19 10" />
                            <Vertex pos="-2 -19 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 2688 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -2432 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -19" album="" material="bm_grid_blank1" texgens="-1 0 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -19" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 -1 0 -2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 256 0 -1 0 -2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="-37 89 -1" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 89 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="26 2 10" />
                            <Vertex pos="26 2 -10" />
                            <Vertex pos="26 -2 10" />
                            <Vertex pos="26 -2 -10" />
                            <Vertex pos="-26 2 10" />
                            <Vertex pos="-26 2 -10" />
                            <Vertex pos="-26 -2 10" />
                            <Vertex pos="-26 -2 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -26" album="" material="bm_grid_blank1" texgens="0 1 0 3584 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -26" album="" material="bm_grid_blank1" texgens="0 -1 0 -3328 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -2304 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 2560 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 2560 0 -1 0 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 -2304 0 -1 0 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="28.75 27.25 3.75" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 27.25 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 4.75" />
                            <Vertex pos="0.25 0.25 -4.75" />
                            <Vertex pos="0.25 -0.25 4.75" />
                            <Vertex pos="0.25 -0.25 -4.75" />
                            <Vertex pos="-0.25 0.25 4.75" />
                            <Vertex pos="-0.25 0.25 -4.75" />
                            <Vertex pos="-0.25 -0.25 4.75" />
                            <Vertex pos="-0.25 -0.25 -4.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4.75" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="28.75 22.75 6" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 22.75 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 7" />
                            <Vertex pos="0.25 0.25 -7" />
                            <Vertex pos="0.25 -0.25 7" />
                            <Vertex pos="0.25 -0.25 -7" />
                            <Vertex pos="-0.25 0.25 7" />
                            <Vertex pos="-0.25 0.25 -7" />
                            <Vertex pos="-0.25 -0.25 7" />
                            <Vertex pos="-0.25 -0.25 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="28.75 39.25 6" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 39.25 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 7" />
                            <Vertex pos="0.25 0.25 -7" />
                            <Vertex pos="0.25 -0.25 7" />
                            <Vertex pos="0.25 -0.25 -7" />
                            <Vertex pos="-0.25 0.25 7" />
                            <Vertex pos="-0.25 0.25 -7" />
                            <Vertex pos="-0.25 -0.25 7" />
                            <Vertex pos="-0.25 -0.25 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="28.75 34.75 3.75" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 34.75 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 4.75" />
                            <Vertex pos="0.25 0.25 -4.75" />
                            <Vertex pos="0.25 -0.25 4.75" />
                            <Vertex pos="0.25 -0.25 -4.75" />
                            <Vertex pos="-0.25 0.25 4.75" />
                            <Vertex pos="-0.25 0.25 -4.75" />
                            <Vertex pos="-0.25 -0.25 4.75" />
                            <Vertex pos="-0.25 -0.25 -4.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4.75" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="28.75 37 2" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 37 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 3" />
                            <Vertex pos="0.25 2 -3" />
                            <Vertex pos="0.25 -2 3" />
                            <Vertex pos="0.25 -2 -3" />
                            <Vertex pos="-0.25 2 3" />
                            <Vertex pos="-0.25 2 -3" />
                            <Vertex pos="-0.25 -2 3" />
                            <Vertex pos="-0.25 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_tile04_C" texgens="0 -1 0 0 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="28.75 25 2" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 25 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 3" />
                            <Vertex pos="0.25 2 -3" />
                            <Vertex pos="0.25 -2 3" />
                            <Vertex pos="0.25 -2 -3" />
                            <Vertex pos="-0.25 2 3" />
                            <Vertex pos="-0.25 2 -3" />
                            <Vertex pos="-0.25 -2 3" />
                            <Vertex pos="-0.25 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_tile04_C" texgens="0 -1 0 0 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="28.75 37 7" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 37 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2" />
                            <Vertex pos="0.25 2 -2" />
                            <Vertex pos="0.25 0 2" />
                            <Vertex pos="0.25 0 -2" />
                            <Vertex pos="-0.25 2 2" />
                            <Vertex pos="-0.25 2 -2" />
                            <Vertex pos="-0.25 0 2" />
                            <Vertex pos="-0.25 0 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="0 -1 -1.5 320 0 0 -1 128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="28.75 31 11" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 31 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8 2" />
                            <Vertex pos="0.25 8 -2" />
                            <Vertex pos="0.25 -8 2" />
                            <Vertex pos="0.25 -8 -2" />
                            <Vertex pos="-0.25 8 2" />
                            <Vertex pos="-0.25 8 -2" />
                            <Vertex pos="-0.25 -8 2" />
                            <Vertex pos="-0.25 -8 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 -768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_tile04_C" texgens="0 -1 0 1536 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="28.75 31 15" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 31 0 0 1 15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2" />
                            <Vertex pos="0.25 2 -2" />
                            <Vertex pos="0.25 -2 2" />
                            <Vertex pos="0.25 -2 -2" />
                            <Vertex pos="-0.25 2 2" />
                            <Vertex pos="-0.25 2 -2" />
                            <Vertex pos="-0.25 -2 2" />
                            <Vertex pos="-0.25 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_tile04_C" texgens="0 -1 0 0 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="28.75 31 19" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 31 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2" />
                            <Vertex pos="0.25 2 -2" />
                            <Vertex pos="0.25 -2 2" />
                            <Vertex pos="0.25 -2 -2" />
                            <Vertex pos="-0.25 2 2" />
                            <Vertex pos="-0.25 2 -2" />
                            <Vertex pos="-0.25 -2 2" />
                            <Vertex pos="-0.25 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_tile04_C" texgens="0 -1 0 0 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="28.75 33.25 17" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 33.25 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 4" />
                            <Vertex pos="0.25 0.25 -4" />
                            <Vertex pos="0.25 -0.25 4" />
                            <Vertex pos="0.25 -0.25 -4" />
                            <Vertex pos="-0.25 0.25 4" />
                            <Vertex pos="-0.25 0.25 -4" />
                            <Vertex pos="-0.25 -0.25 4" />
                            <Vertex pos="-0.25 -0.25 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="28.75 28.75 17" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 28.75 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 4" />
                            <Vertex pos="0.25 0.25 -4" />
                            <Vertex pos="0.25 -0.25 4" />
                            <Vertex pos="0.25 -0.25 -4" />
                            <Vertex pos="-0.25 0.25 4" />
                            <Vertex pos="-0.25 0.25 -4" />
                            <Vertex pos="-0.25 -0.25 4" />
                            <Vertex pos="-0.25 -0.25 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="28.75 31 21.25" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 31 0 0 1 21.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.5 0.25" />
                            <Vertex pos="0.25 2.5 -0.25" />
                            <Vertex pos="0.25 -2.5 0.25" />
                            <Vertex pos="0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 2.5 0.25" />
                            <Vertex pos="-0.25 2.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 0.25" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="28.75 36.5 13.25" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 36.5 0 0 1 13.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1280 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1408 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="28.75 25.5 13.25" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 25.5 0 0 1 13.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1280 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1408 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="28.75 31 8.75" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 31 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1024 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1152 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="-10.75 34.75 4" rot="1 0 0 0" scale="" transform="1 0 0 -10.75 0 1 0 34.75 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 5" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 -0.25 5" />
                            <Vertex pos="0.25 -0.25 -5" />
                            <Vertex pos="-0.25 0.25 5" />
                            <Vertex pos="-0.25 0.25 -5" />
                            <Vertex pos="-0.25 -0.25 5" />
                            <Vertex pos="-0.25 -0.25 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="-13 34.75 1" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 34.75 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 2" />
                            <Vertex pos="2 0.25 -2" />
                            <Vertex pos="2 -0.25 2" />
                            <Vertex pos="2 -0.25 -2" />
                            <Vertex pos="-2 0.25 2" />
                            <Vertex pos="-2 0.25 -2" />
                            <Vertex pos="-2 -0.25 2" />
                            <Vertex pos="-2 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 2112 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_tile04_C" texgens="1 0 0 4608 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 4608 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-12 34.75 4" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 34.75 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 1" />
                            <Vertex pos="1 0.25 -1" />
                            <Vertex pos="1 -0.25 1" />
                            <Vertex pos="1 -0.25 -1" />
                            <Vertex pos="-1 0.25 1" />
                            <Vertex pos="-1 0.25 -1" />
                            <Vertex pos="-1 -0.25 1" />
                            <Vertex pos="-1 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="1 0 1.5 160 0 0 -1 64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 4864 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-13 34.75 7" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 34.75 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 2" />
                            <Vertex pos="2 0.25 -2" />
                            <Vertex pos="2 -0.25 2" />
                            <Vertex pos="2 -0.25 -2" />
                            <Vertex pos="-2 0.25 2" />
                            <Vertex pos="-2 0.25 -2" />
                            <Vertex pos="-2 -0.25 2" />
                            <Vertex pos="-2 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_tile04_C" texgens="1 0 0 4608 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 4608 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-17 29.25 1" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 29.25 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 2" />
                            <Vertex pos="2 0.25 -2" />
                            <Vertex pos="2 -0.25 2" />
                            <Vertex pos="2 -0.25 -2" />
                            <Vertex pos="-2 0.25 2" />
                            <Vertex pos="-2 0.25 -2" />
                            <Vertex pos="-2 -0.25 2" />
                            <Vertex pos="-2 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 -1984 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_tile04_C" texgens="-1 0 0 0 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 4608 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-16 29.25 4" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 29.25 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 1" />
                            <Vertex pos="1 0.25 -1" />
                            <Vertex pos="1 -0.25 1" />
                            <Vertex pos="1 -0.25 -1" />
                            <Vertex pos="-1 0.25 1" />
                            <Vertex pos="-1 0.25 -1" />
                            <Vertex pos="-1 -0.25 1" />
                            <Vertex pos="-1 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 -1.5 160 0 0 -1 64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 4864 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="-17 29.25 7" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 29.25 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 2" />
                            <Vertex pos="2 0.25 -2" />
                            <Vertex pos="2 -0.25 2" />
                            <Vertex pos="2 -0.25 -2" />
                            <Vertex pos="-2 0.25 2" />
                            <Vertex pos="-2 0.25 -2" />
                            <Vertex pos="-2 -0.25 2" />
                            <Vertex pos="-2 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_tile04_C" texgens="-1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 4608 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="-19.25 29.25 4" rot="1 0 0 0" scale="" transform="1 0 0 -19.25 0 1 0 29.25 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 5" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 -0.25 5" />
                            <Vertex pos="0.25 -0.25 -5" />
                            <Vertex pos="-0.25 0.25 5" />
                            <Vertex pos="-0.25 0.25 -5" />
                            <Vertex pos="-0.25 -0.25 5" />
                            <Vertex pos="-0.25 -0.25 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="-14.75 29.25 6" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 29.25 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.249999 0.250002 3" />
                            <Vertex pos="0.249999 0.250002 -2.5" />
                            <Vertex pos="0.249999 -0.250002 3" />
                            <Vertex pos="0.249999 -0.250002 -2.5" />
                            <Vertex pos="-0.249999 0.250002 3" />
                            <Vertex pos="-0.249999 0.250002 -3" />
                            <Vertex pos="-0.249999 -0.250002 3" />
                            <Vertex pos="-0.249999 -0.250002 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.249999" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.249999" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.250002" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.250002" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707108 0 -0.707105 -1.94454" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="-15.25 34.75 6" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 34.75 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3" />
                            <Vertex pos="0.25 0.25 -3" />
                            <Vertex pos="0.25 -0.25 3" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="-0.25 0.25 -2.5" />
                            <Vertex pos="-0.25 -0.25 3" />
                            <Vertex pos="-0.25 -0.25 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -1.94454" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="-51.25 27.25 2" rot="1 0 0 0" scale="" transform="1 0 0 -51.25 0 1 0 27.25 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 5" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 -0.25 5" />
                            <Vertex pos="0.25 -0.25 -5" />
                            <Vertex pos="-0.25 0.25 5" />
                            <Vertex pos="-0.25 0.25 -5" />
                            <Vertex pos="-0.25 -0.25 5" />
                            <Vertex pos="-0.25 -0.25 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="-51.25 22.75 2" rot="1 0 0 0" scale="" transform="1 0 0 -51.25 0 1 0 22.75 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 5" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 -0.25 5" />
                            <Vertex pos="0.25 -0.25 -5" />
                            <Vertex pos="-0.25 0.25 5" />
                            <Vertex pos="-0.25 0.25 -5" />
                            <Vertex pos="-0.25 -0.25 5" />
                            <Vertex pos="-0.25 -0.25 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="-51.25 25 -1" rot="1 0 0 0" scale="" transform="1 0 0 -51.25 0 1 0 25 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2" />
                            <Vertex pos="0.25 2 -2" />
                            <Vertex pos="0.25 -2 2" />
                            <Vertex pos="0.25 -2 -2" />
                            <Vertex pos="-0.25 2 2" />
                            <Vertex pos="-0.25 2 -2" />
                            <Vertex pos="-0.25 -2 2" />
                            <Vertex pos="-0.25 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_tile04_C" texgens="0 -1 0 0 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="-51.25 24 2" rot="1 0 0 0" scale="" transform="1 0 0 -51.25 0 1 0 24 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 1" />
                            <Vertex pos="0.25 1 -1" />
                            <Vertex pos="0.25 -1 1" />
                            <Vertex pos="0.25 -1 -1" />
                            <Vertex pos="-0.25 1 1" />
                            <Vertex pos="-0.25 1 -1" />
                            <Vertex pos="-0.25 -1 1" />
                            <Vertex pos="-0.25 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="0 -1 1.5 160 0 0 -1 64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="-51.25 25 5" rot="1 0 0 0" scale="" transform="1 0 0 -51.25 0 1 0 25 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2" />
                            <Vertex pos="0.25 2 -2" />
                            <Vertex pos="0.25 -2 2" />
                            <Vertex pos="0.25 -2 -2" />
                            <Vertex pos="-0.25 2 2" />
                            <Vertex pos="-0.25 2 -2" />
                            <Vertex pos="-0.25 -2 2" />
                            <Vertex pos="-0.25 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_friction_bounce_med" texgens="0 -1 0 0 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="-78.75 27.25 2" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 27.25 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 5" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 -0.25 5" />
                            <Vertex pos="0.25 -0.25 -5" />
                            <Vertex pos="-0.25 0.25 5" />
                            <Vertex pos="-0.25 0.25 -5" />
                            <Vertex pos="-0.25 -0.25 5" />
                            <Vertex pos="-0.25 -0.25 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="-78.75 22.75 2" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 22.75 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 5" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 -0.25 5" />
                            <Vertex pos="0.25 -0.25 -5" />
                            <Vertex pos="-0.25 0.25 5" />
                            <Vertex pos="-0.25 0.25 -5" />
                            <Vertex pos="-0.25 -0.25 5" />
                            <Vertex pos="-0.25 -0.25 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="-78.75 25 -1" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 25 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2" />
                            <Vertex pos="0.25 2 -2" />
                            <Vertex pos="0.25 -2 2" />
                            <Vertex pos="0.25 -2 -2" />
                            <Vertex pos="-0.25 2 2" />
                            <Vertex pos="-0.25 2 -2" />
                            <Vertex pos="-0.25 -2 2" />
                            <Vertex pos="-0.25 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_tile04_C" texgens="0 1 0 0 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="-78.75 24 2" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 24 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 1" />
                            <Vertex pos="0.25 1 -1" />
                            <Vertex pos="0.25 -1 1" />
                            <Vertex pos="0.25 -1 -1" />
                            <Vertex pos="-0.25 1 1" />
                            <Vertex pos="-0.25 1 -1" />
                            <Vertex pos="-0.25 -1 1" />
                            <Vertex pos="-0.25 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="0 1 -1.5 160 0 0 -1 64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="-78.75 25 5" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 25 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2" />
                            <Vertex pos="0.25 2 -2" />
                            <Vertex pos="0.25 -2 2" />
                            <Vertex pos="0.25 -2 -2" />
                            <Vertex pos="-0.25 2 2" />
                            <Vertex pos="-0.25 2 -2" />
                            <Vertex pos="-0.25 -2 2" />
                            <Vertex pos="-0.25 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_friction_bounce_med" texgens="0 1 0 0 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="-78.75 25 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 25 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.5 0.25" />
                            <Vertex pos="0.25 2.5 -0.25" />
                            <Vertex pos="0.25 -2.5 0.25" />
                            <Vertex pos="0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 2.5 0.25" />
                            <Vertex pos="-0.25 2.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 0.25" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="-51.25 25 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -51.25 0 1 0 25 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.5 0.25" />
                            <Vertex pos="0.25 2.5 -0.25" />
                            <Vertex pos="0.25 -2.5 0.25" />
                            <Vertex pos="0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 2.5 0.25" />
                            <Vertex pos="-0.25 2.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 0.25" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="-17 29.25 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 29.25 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.25 0.25" />
                            <Vertex pos="2.5 0.25 -0.25" />
                            <Vertex pos="2.5 -0.25 0.25" />
                            <Vertex pos="2.5 -0.25 -0.25" />
                            <Vertex pos="-2.5 0.25 0.25" />
                            <Vertex pos="-2.5 0.25 -0.25" />
                            <Vertex pos="-2.5 -0.25 0.25" />
                            <Vertex pos="-2.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 192 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -5504 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5632 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5632 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 -1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="-13 34.75 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 34.75 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.25 0.25" />
                            <Vertex pos="2.5 0.25 -0.25" />
                            <Vertex pos="2.5 -0.25 0.25" />
                            <Vertex pos="2.5 -0.25 -0.25" />
                            <Vertex pos="-2.5 0.25 0.25" />
                            <Vertex pos="-2.5 0.25 -0.25" />
                            <Vertex pos="-2.5 -0.25 0.25" />
                            <Vertex pos="-2.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 192 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -5504 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5632 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5632 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 -1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="1 93 -4.24999" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 93 0 0 1 -4.24999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 2 -0.750016" />
                            <Vertex pos="10 2 -1.25001" />
                            <Vertex pos="10 -2 1.25001" />
                            <Vertex pos="10 -2 0.749994" />
                            <Vertex pos="-10 2 -0.750016" />
                            <Vertex pos="-10 2 -1.25001" />
                            <Vertex pos="-10 -2 1.25001" />
                            <Vertex pos="-10 -2 0.749994" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -10" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 319.995 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 319.995 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 319.995 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 319.995 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447218 0.894425 -0.223604" album="" material="bm_friction_sand" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.223614" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="-94.75 40.75 4" rot="1 0 0 0" scale="" transform="1 0 0 -94.75 0 1 0 40.75 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 7" />
                            <Vertex pos="0.25 0.25 -7" />
                            <Vertex pos="0.25 -0.25 7" />
                            <Vertex pos="0.25 -0.25 -7" />
                            <Vertex pos="-0.25 0.25 7" />
                            <Vertex pos="-0.25 0.25 -7" />
                            <Vertex pos="-0.25 -0.25 7" />
                            <Vertex pos="-0.25 -0.25 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="-97 40.75 0" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 40.75 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 3" />
                            <Vertex pos="2 0.25 -3" />
                            <Vertex pos="2 -0.25 3" />
                            <Vertex pos="2 -0.25 -3" />
                            <Vertex pos="-2 0.25 3" />
                            <Vertex pos="-2 0.25 -3" />
                            <Vertex pos="-2 -0.25 3" />
                            <Vertex pos="-2 -0.25 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_tile04_C" texgens="1 0 0 4608 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_edge_white" texgens="1 0 0 4608 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="-95 40.75 5" rot="1 0 0 0" scale="" transform="1 0 0 -95 0 1 0 40.75 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 0.25 2" />
                            <Vertex pos="0 0.25 -2" />
                            <Vertex pos="0 -0.25 2" />
                            <Vertex pos="0 -0.25 -2" />
                            <Vertex pos="-2 0.25 2" />
                            <Vertex pos="-2 0.25 -2" />
                            <Vertex pos="-2 -0.25 2" />
                            <Vertex pos="-2 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="1 0 1.5 256 0 0 -1 128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 4608 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="-97 40.75 9" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 40.75 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 2" />
                            <Vertex pos="2 0.25 -2" />
                            <Vertex pos="2 -0.25 2" />
                            <Vertex pos="2 -0.25 -2" />
                            <Vertex pos="-2 0.25 2" />
                            <Vertex pos="-2 0.25 -2" />
                            <Vertex pos="-2 -0.25 2" />
                            <Vertex pos="-2 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_tile04_C" texgens="1 0 0 4608 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 4608 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="-99.25 40.75 4" rot="1 0 0 0" scale="" transform="1 0 0 -99.25 0 1 0 40.75 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 7" />
                            <Vertex pos="0.25 0.25 -7" />
                            <Vertex pos="0.25 -0.25 7" />
                            <Vertex pos="0.25 -0.25 -7" />
                            <Vertex pos="-0.25 0.25 7" />
                            <Vertex pos="-0.25 0.25 -7" />
                            <Vertex pos="-0.25 -0.25 7" />
                            <Vertex pos="-0.25 -0.25 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="-97 40.75 11.25" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 40.75 0 0 1 11.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.25 0.25" />
                            <Vertex pos="2.5 0.25 -0.25" />
                            <Vertex pos="2.5 -0.25 0.25" />
                            <Vertex pos="2.5 -0.25 -0.25" />
                            <Vertex pos="-2.5 0.25 0.25" />
                            <Vertex pos="-2.5 0.25 -0.25" />
                            <Vertex pos="-2.5 -0.25 0.25" />
                            <Vertex pos="-2.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 192 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -5504 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5632 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5632 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 -1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="-58.75 81.25 4" rot="1 0 0 0" scale="" transform="1 0 0 -58.75 0 1 0 81.25 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 7" />
                            <Vertex pos="0.25 0.25 -7" />
                            <Vertex pos="0.25 -0.25 7" />
                            <Vertex pos="0.25 -0.25 -7" />
                            <Vertex pos="-0.25 0.25 7" />
                            <Vertex pos="-0.25 0.25 -7" />
                            <Vertex pos="-0.25 -0.25 7" />
                            <Vertex pos="-0.25 -0.25 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="-58.75 76.75 4" rot="1 0 0 0" scale="" transform="1 0 0 -58.75 0 1 0 76.75 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 7" />
                            <Vertex pos="0.25 0.25 -7" />
                            <Vertex pos="0.25 -0.25 7" />
                            <Vertex pos="0.25 -0.25 -7" />
                            <Vertex pos="-0.25 0.25 7" />
                            <Vertex pos="-0.25 0.25 -7" />
                            <Vertex pos="-0.25 -0.25 7" />
                            <Vertex pos="-0.25 -0.25 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="-58.75 79 0" rot="1 0 0 0" scale="" transform="1 0 0 -58.75 0 1 0 79 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 3" />
                            <Vertex pos="0.25 2 -3" />
                            <Vertex pos="0.25 -2 3" />
                            <Vertex pos="0.25 -2 -3" />
                            <Vertex pos="-0.25 2 3" />
                            <Vertex pos="-0.25 2 -3" />
                            <Vertex pos="-0.25 -2 3" />
                            <Vertex pos="-0.25 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_tile04_C" texgens="0 1 0 0 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="-58.75 81 5" rot="1 0 0 0" scale="" transform="1 0 0 -58.75 0 1 0 81 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0 2" />
                            <Vertex pos="0.25 0 -2" />
                            <Vertex pos="0.25 -2 2" />
                            <Vertex pos="0.25 -2 -2" />
                            <Vertex pos="-0.25 0 2" />
                            <Vertex pos="-0.25 0 -2" />
                            <Vertex pos="-0.25 -2 2" />
                            <Vertex pos="-0.25 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="0 1 1.5 384 0 0 -1 128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="-58.75 79 11.25" rot="1 0 0 0" scale="" transform="1 0 0 -58.75 0 1 0 79 0 0 1 11.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.5 0.25" />
                            <Vertex pos="0.25 2.5 -0.25" />
                            <Vertex pos="0.25 -2.5 0.25" />
                            <Vertex pos="0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 2.5 0.25" />
                            <Vertex pos="-0.25 2.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 0.25" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="-58.75 79 9" rot="1 0 0 0" scale="" transform="1 0 0 -58.75 0 1 0 79 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2" />
                            <Vertex pos="0.25 2 -2" />
                            <Vertex pos="0.25 -2 2" />
                            <Vertex pos="0.25 -2 -2" />
                            <Vertex pos="-0.25 2 2" />
                            <Vertex pos="-0.25 2 -2" />
                            <Vertex pos="-0.25 -2 2" />
                            <Vertex pos="-0.25 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_tile04_C" texgens="0 1 0 0 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="-103 -7 -1" rot="1 0 0 0" scale="" transform="1 0 0 -103 0 1 0 -7 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 24 10" />
                            <Vertex pos="2 24 -10" />
                            <Vertex pos="2 -24 10" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 24 10" />
                            <Vertex pos="-2 24 -10" />
                            <Vertex pos="-2 -24 10" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -24" album="" material="bm_grid_blank1" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="" material="bm_grid_blank1" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="-65 -29 -1" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 -29 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="36 2 10" />
                            <Vertex pos="36 2 -10" />
                            <Vertex pos="36 -2 10" />
                            <Vertex pos="36 -2 -10" />
                            <Vertex pos="-36 2 10" />
                            <Vertex pos="-36 2 -10" />
                            <Vertex pos="-36 -2 10" />
                            <Vertex pos="-36 -2 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -36" album="" material="bm_grid_blank1" texgens="0 1 0 -2048 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -36" album="" material="bm_grid_blank1" texgens="0 -1 0 2304 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -3840 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 4096 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 4096 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 -3840 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="-27 -23 -1" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 -23 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 8 10" />
                            <Vertex pos="2 8 -10" />
                            <Vertex pos="2 -8 10" />
                            <Vertex pos="2 -8 -10" />
                            <Vertex pos="-2 8 10" />
                            <Vertex pos="-2 8 -10" />
                            <Vertex pos="-2 -8 10" />
                            <Vertex pos="-2 -8 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 -1536 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 1792 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank1" texgens="-1 0 0 256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 256 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="-13 99 -1" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 99 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 8 10" />
                            <Vertex pos="2 8 -10" />
                            <Vertex pos="2 -8 10" />
                            <Vertex pos="2 -8 -10" />
                            <Vertex pos="-2 8 10" />
                            <Vertex pos="-2 8 -10" />
                            <Vertex pos="-2 -8 10" />
                            <Vertex pos="-2 -8 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 4352 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -4096 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank1" texgens="-1 0 0 -5376 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank1" texgens="1 0 0 5632 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 5632 0 -1 0 -4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 -5376 0 -1 0 -4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="15 77 -1" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 77 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 30 10" />
                            <Vertex pos="2 30 -10" />
                            <Vertex pos="2 -30 10" />
                            <Vertex pos="2 -30 -10" />
                            <Vertex pos="-2 30 10" />
                            <Vertex pos="-2 30 -10" />
                            <Vertex pos="-2 -30 10" />
                            <Vertex pos="-2 -30 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 1536 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -30" album="" material="bm_grid_blank1" texgens="-1 0 0 -5376 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -30" album="" material="bm_grid_blank1" texgens="1 0 0 5632 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 5632 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 -5376 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="1 105 -1" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 105 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 2 10" />
                            <Vertex pos="12 2 -10" />
                            <Vertex pos="12 -2 10" />
                            <Vertex pos="12 -2 -10" />
                            <Vertex pos="-12 2 10" />
                            <Vertex pos="-12 2 -10" />
                            <Vertex pos="-12 -2 10" />
                            <Vertex pos="-12 -2 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank1" texgens="0 1 0 3584 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank1" texgens="0 -1 0 -3328 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -6656 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 6912 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank1" texgens="1 0 0 6912 0 -1 0 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 -6656 0 -1 0 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="-99.25 -10.75 1" rot="1 0 0 0" scale="" transform="1 0 0 -99.25 0 1 0 -10.75 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="-30.75 -10.75 1" rot="1 0 0 0" scale="" transform="1 0 0 -30.75 0 1 0 -10.75 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="-30.75 -14.75 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -30.75 0 1 0 -14.75 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 0.25" />
                            <Vertex pos="0.25 4.25 -0.25" />
                            <Vertex pos="0.25 -4.25 0.25" />
                            <Vertex pos="0.25 -4.25 -0.25" />
                            <Vertex pos="-0.25 4.25 0.25" />
                            <Vertex pos="-0.25 4.25 -0.25" />
                            <Vertex pos="-0.25 -4.25 0.25" />
                            <Vertex pos="-0.25 -4.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -3008 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 3136 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="-99.25 -14.75 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -99.25 0 1 0 -14.75 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 0.25" />
                            <Vertex pos="0.25 4.25 -0.25" />
                            <Vertex pos="0.25 -4.25 0.25" />
                            <Vertex pos="0.25 -4.25 -0.25" />
                            <Vertex pos="-0.25 4.25 0.25" />
                            <Vertex pos="-0.25 4.25 -0.25" />
                            <Vertex pos="-0.25 -4.25 0.25" />
                            <Vertex pos="-0.25 -4.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -3008 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 3136 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="-65 -25.25 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 -25.25 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="28 0.25 0.25" />
                            <Vertex pos="28 0.25 -0.25" />
                            <Vertex pos="28 -0.25 0.25" />
                            <Vertex pos="28 -0.25 -0.25" />
                            <Vertex pos="-28 0.25 0.25" />
                            <Vertex pos="-28 0.25 -0.25" />
                            <Vertex pos="-28 -0.25 0.25" />
                            <Vertex pos="-28 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -28" album="" material="bm_edge_white" texgens="0 1 0 -4032 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -28" album="" material="bm_edge_white" texgens="0 -1 0 4160 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -12032 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 12160 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 12160 0 -1 0 4160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -7040 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="11.25 86.75 -1" rot="1 0 0 0" scale="" transform="1 0 0 11.25 0 1 0 86.75 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="11.25 90.75 1.25" rot="1 0 0 0" scale="" transform="1 0 0 11.25 0 1 0 90.75 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 0.25" />
                            <Vertex pos="0.25 4.25 -0.25" />
                            <Vertex pos="0.25 -4.25 0.25" />
                            <Vertex pos="0.25 -4.25 -0.25" />
                            <Vertex pos="-0.25 4.25 0.25" />
                            <Vertex pos="-0.25 4.25 -0.25" />
                            <Vertex pos="-0.25 -4.25 0.25" />
                            <Vertex pos="-0.25 -4.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -3008 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 3136 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="-9.25 86.75 -1" rot="1 0 0 0" scale="" transform="1 0 0 -9.25 0 1 0 86.75 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="-9.25 90.75 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -9.25 0 1 0 90.75 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 0.25" />
                            <Vertex pos="0.25 4.25 -0.25" />
                            <Vertex pos="0.25 -4.25 0.25" />
                            <Vertex pos="0.25 -4.25 -0.25" />
                            <Vertex pos="-0.25 4.25 0.25" />
                            <Vertex pos="-0.25 4.25 -0.25" />
                            <Vertex pos="-0.25 -4.25 0.25" />
                            <Vertex pos="-0.25 -4.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -3008 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 3136 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="1 101.25 1.25" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 101.25 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -5888 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 6016 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 6016 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="-67 9 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -67 0 1 0 9 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-6 2 0.25" />
                            <Vertex pos="-6 2 -0.25" />
                            <Vertex pos="-6 -2 0.25" />
                            <Vertex pos="-6 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 1024 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 2048 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile07_C" texgens="1 0 0 2048 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="-72 10 -3" rot="1 0 0 0" scale="" transform="1 0 0 -72 0 1 0 10 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="-1 1 0" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 0" />
                            <Vertex pos="-3 3 0" />
                            <Vertex pos="-3 3 -0.5" />
                            <Vertex pos="-3 -1 0" />
                            <Vertex pos="-3 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 1" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.82843" album="" material="bm_edge_white" texgens="1 0 0 1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.727607" album="" material="bm_grid_blank2" texgens="1 0 0 -384 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -640 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="-62 10 -3" rot="1 0 0 0" scale="" transform="1 0 0 -62 0 1 0 10 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 -9.53674e-007" />
                            <Vertex pos="1 3 -0.499999" />
                            <Vertex pos="1 -1 -9.53674e-007" />
                            <Vertex pos="1 -1 -0.499999" />
                            <Vertex pos="-1 0.999998 0.499999" />
                            <Vertex pos="-1 1 -1.90735e-006" />
                            <Vertex pos="-1 -3 0.499999" />
                            <Vertex pos="-1 -3 -1.90735e-006" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242534 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="-67 12 -3" rot="1 0 0 0" scale="" transform="1 0 0 -67 0 1 0 12 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 0" />
                            <Vertex pos="6 1 -0.5" />
                            <Vertex pos="4 -1 0.5" />
                            <Vertex pos="4 -1 0" />
                            <Vertex pos="-8 1 0" />
                            <Vertex pos="-8 1 -0.5" />
                            <Vertex pos="-6 -1 0.5" />
                            <Vertex pos="-6 -1 0" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -3.53553" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -4.94975" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -768 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="-59 42 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 -59 0 1 0 42 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 0.25" />
                            <Vertex pos="6 1 -0.25" />
                            <Vertex pos="6 -1 0.25" />
                            <Vertex pos="6 -1 -0.25" />
                            <Vertex pos="-6 1 0.25" />
                            <Vertex pos="-6 1 -0.25" />
                            <Vertex pos="-6 -1 0.25" />
                            <Vertex pos="-6 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -3456 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 3584 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_C" texgens="1 0 0 3584 0 -1 0 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1536 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="-66 42 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -66 0 1 0 42 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1.00001 2.38419e-007" />
                            <Vertex pos="1 1.00001 -0.5" />
                            <Vertex pos="1 -0.999996 2.38419e-007" />
                            <Vertex pos="1 -1.00001 -0.5" />
                            <Vertex pos="-1 3.00001 0.5" />
                            <Vertex pos="-1 3.00001 -2.38419e-007" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3.00001 -2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41422" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707109 -0.707104 1.41613e-005 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="-52 49 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 49 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 9.99999 0.499998" />
                            <Vertex pos="1 10 1.66893e-006" />
                            <Vertex pos="1 -9.99999 0.499998" />
                            <Vertex pos="1 -9.99999 1.43051e-006" />
                            <Vertex pos="-1 7.99999 1.43051e-006" />
                            <Vertex pos="-1 8 -0.499998" />
                            <Vertex pos="-1 -7.99999 1.19209e-006" />
                            <Vertex pos="-1 -7.99999 -0.499998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707108 0.707105 1.34871e-005 -6.36394" album="" material="bm_edge_white" texgens="-1 0 0 -4736 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -6.36395" album="" material="bm_edge_white" texgens="1 0 0 4864 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242534 -1.44564e-008 0.970143 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 1152 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242535 1.15651e-008 -0.970142 -0.242534" album="" material="bm_grid_blank1" texgens="-1 0 0 -2176 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="-59 40 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -59 0 1 0 40 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.99999 1 -1.19209e-006" />
                            <Vertex pos="6 1 -0.5" />
                            <Vertex pos="8 -1 0.5" />
                            <Vertex pos="7.99999 -1 2.38419e-007" />
                            <Vertex pos="-5.99999 1 -1.19209e-006" />
                            <Vertex pos="-5.99999 1 -0.5" />
                            <Vertex pos="-8 -1 0.5" />
                            <Vertex pos="-7.99999 -1 2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 -1.41613e-005 -4.94974" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -4.94974" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -3456 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 3584 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 512 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -0.242535" album="" material="bm_grid_blank1" texgens="-1 0 0 -1536 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="-61 44 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -61 0 1 0 44 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 0.500002" />
                            <Vertex pos="4 1 -1.66893e-006" />
                            <Vertex pos="6 -1 -1.43051e-006" />
                            <Vertex pos="6 -1 -0.500002" />
                            <Vertex pos="-5.99999 1 0.500002" />
                            <Vertex pos="-6 1 -1.66893e-006" />
                            <Vertex pos="-3.99999 -1 -1.43051e-006" />
                            <Vertex pos="-4 -1 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -3.53553" album="" material="bm_edge_white" texgens="0 1 0 -4736 0 0 -1 128.002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707105 -0.707108 1.41612e-005 -3.53552" album="" material="bm_edge_white" texgens="0 -1 0 4864 0 0 -1 128.002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -3968 0 0 -1 128.002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -1" album="" material="bm_edge_white" texgens="1 0 0 4096 0 0 -1 128.002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242537 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 768 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 -0.242537" album="" material="bm_grid_blank1" texgens="-1 0 0 -1792 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="-35 45 -1.75" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 45 0 0 1 -1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 2 1.25" />
                            <Vertex pos="-4 2 0.75" />
                            <Vertex pos="-4 -2 1.25" />
                            <Vertex pos="-4 -2 0.75" />
                            <Vertex pos="-8 2 0.75" />
                            <Vertex pos="-8 2 0.25" />
                            <Vertex pos="-8 -2 0.75" />
                            <Vertex pos="-8 -2 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.124035 0 0.992278 -1.73649" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.124035 0 -0.992278 1.24035" album="" material="bm_grid_blank1" texgens="-1 0 0 512 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="-42 45 -2" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 45 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 2 1" />
                            <Vertex pos="-1 2 0.5" />
                            <Vertex pos="-1 -2 1" />
                            <Vertex pos="-1 -2 0.5" />
                            <Vertex pos="-9 2 -1" />
                            <Vertex pos="-9 2 -1.5" />
                            <Vertex pos="-9 -2 -1" />
                            <Vertex pos="-9 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 1" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 896 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -768 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -1.21268" album="" material="bm_tile09_C" texgens="1 0 0 -768 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 0.727607" album="" material="bm_grid_blank1" texgens="-1 0 0 640 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="-54 50 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 -54 0 1 0 50 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 7 0.25" />
                            <Vertex pos="1 7 -0.25" />
                            <Vertex pos="1 -7 0.25" />
                            <Vertex pos="1 -7 -0.25" />
                            <Vertex pos="-1 7 0.25" />
                            <Vertex pos="-1 7 -0.25" />
                            <Vertex pos="-1 -7 0.25" />
                            <Vertex pos="-1 -7 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_edge_white" texgens="-1 0 0 -4736 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_edge_white" texgens="1 0 0 4864 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_C" texgens="1 0 0 4864 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -2176 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="-56 51 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -56 0 1 0 51 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 2.38419e-007" />
                            <Vertex pos="1 6 -0.5" />
                            <Vertex pos="1 -8 2.38419e-007" />
                            <Vertex pos="1 -8 -0.5" />
                            <Vertex pos="-1 8 0.5" />
                            <Vertex pos="-1 8 -2.38419e-007" />
                            <Vertex pos="-1 -6 0.5" />
                            <Vertex pos="-1 -6 -2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3456 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3584 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.94975" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -4.94975" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="-54 58 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -54 0 1 0 58 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.00001 1 0.500001" />
                            <Vertex pos="3.00001 1 -4.76837e-007" />
                            <Vertex pos="1.00001 -1 7.15256e-007" />
                            <Vertex pos="1.00001 -1 -0.5" />
                            <Vertex pos="-3.00001 1 0.500001" />
                            <Vertex pos="-3.00001 1 -4.76837e-007" />
                            <Vertex pos="-1.00001 -1 7.15256e-007" />
                            <Vertex pos="-1.00001 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.41422" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.41422" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 -384 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242535 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -640 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="2 43 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 43 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 4 0.25" />
                            <Vertex pos="-1 4 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile07_C" texgens="1 0 0 2816 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="0 43 -1" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 43 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.5" />
                            <Vertex pos="1 3.99999 0" />
                            <Vertex pos="1 -4 0.5" />
                            <Vertex pos="1 -4 0" />
                            <Vertex pos="-1 6 0" />
                            <Vertex pos="-1 5.99999 -0.5" />
                            <Vertex pos="-1 -6 0" />
                            <Vertex pos="-1 -6 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707108 0.707105 -1.41613e-005 -3.53552" album="" material="bm_edge_white" texgens="-1 0 0 -3200 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -3.53553" album="" material="bm_edge_white" texgens="1 0 0 3328 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 384 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1408 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="4 43 -1" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 43 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 0" />
                            <Vertex pos="1 6 -0.5" />
                            <Vertex pos="1 -6 0" />
                            <Vertex pos="1 -6 -0.5" />
                            <Vertex pos="-1 4 0.5" />
                            <Vertex pos="-1 4 -1.19209e-007" />
                            <Vertex pos="-1 -4 0.5" />
                            <Vertex pos="-1 -4 -1.19209e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -3.53553" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -3.53553" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="2 38 -1" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 38 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999998 1 0.500001" />
                            <Vertex pos="0.999998 1 -1.54972e-006" />
                            <Vertex pos="3 -1 1.43051e-006" />
                            <Vertex pos="3 -1 -0.500001" />
                            <Vertex pos="-0.999999 1 0.500001" />
                            <Vertex pos="-0.999995 1 -1.54972e-006" />
                            <Vertex pos="-3 -1 1.43051e-006" />
                            <Vertex pos="-2.99999 -1 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="0.707106 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 -5.64765e-006 -1.41421" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242535 0.970142 -0.242537" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242535 -0.970142 -0.242537" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="2 48 -0.999997" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 48 0 0 1 -0.999997 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 -3.15905e-006" />
                            <Vertex pos="3 1 -0.499997" />
                            <Vertex pos="1.00001 -1 0.499997" />
                            <Vertex pos="1.00001 -1 1.07288e-006" />
                            <Vertex pos="-3 1 -3.15905e-006" />
                            <Vertex pos="-3 1 -0.499997" />
                            <Vertex pos="-1.00001 -1 0.499997" />
                            <Vertex pos="-1.00001 -1 1.07288e-006" />
                        </Vertices>
                        <Face id="0" plane="0.707108 -0.707105 0 -1.41422" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 -0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707109 -0.707105 0 -1.41422" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 -0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 -0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 -0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.242533" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242535 -0.970143 -0.242534" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="-80 -9.5 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -80 0 1 0 -9.5 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile07_C" texgens="1 0 0 2816 0 -1 0 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="-82 -9.5 -0.999998" rot="1 0 0 0" scale="" transform="1 0 0 -82 0 1 0 -9.5 0 0 1 -0.999998 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.999993 0.499996" />
                            <Vertex pos="1 0.999993 -1.84774e-006" />
                            <Vertex pos="1 -0.999991 0.499997" />
                            <Vertex pos="1 -1.00002 -2.86102e-006" />
                            <Vertex pos="-1 2.99999 1.72853e-006" />
                            <Vertex pos="-1 2.99999 -0.499996" />
                            <Vertex pos="-1 -2.99996 2.98023e-006" />
                            <Vertex pos="-1 -2.99999 -0.499997" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 -0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 -0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707106 0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 -3200 0 0 -1 -0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707096 -0.707118 4.24847e-005 -1.41423" album="" material="bm_edge_white" texgens="1 0 0 3328 0 0 -1 -0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242533 2.0239e-007 0.970143 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 384 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242532 4.9151e-007 -0.970143 -0.242535" album="" material="bm_grid_blank1" texgens="-1 0 0 -1408 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="-78 -9.5 -1" rot="1 0 0 0" scale="" transform="1 0 0 -78 0 1 0 -9.5 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.99999 -4.76837e-007" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -2.99999 -4.76837e-007" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 0.99999 0.5" />
                            <Vertex pos="-1 0.999995 4.17233e-007" />
                            <Vertex pos="-1 -0.99999 0.5" />
                            <Vertex pos="-1 -0.999996 4.17233e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707106 0.707108 1.41614e-005 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707106 -0.707108 8.51368e-006 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.242535" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="-80 -11.5 -1" rot="1 0 0 0" scale="" transform="1 0 0 -80 0 1 0 -11.5 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.5" />
                            <Vertex pos="1 1 -2.98023e-007" />
                            <Vertex pos="3 -1 2.38419e-007" />
                            <Vertex pos="3 -1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="-1 1 -2.98023e-007" />
                            <Vertex pos="-3 -1 2.38419e-007" />
                            <Vertex pos="-3 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242535 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="-80 -7.5 -1" rot="1 0 0 0" scale="" transform="1 0 0 -80 0 1 0 -7.5 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 1.19209e-007" />
                            <Vertex pos="3 1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 -1 -1.19209e-007" />
                            <Vertex pos="-3 1 1.19209e-007" />
                            <Vertex pos="-3 1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 -1 -1.19209e-007" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 1 0 -4736 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 -1 0 4864 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="-54 68 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -54 0 1 0 68 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile07_C" texgens="1 0 0 2816 0 -1 0 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="-56 68 -3" rot="1 0 0 0" scale="" transform="1 0 0 -56 0 1 0 68 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.5" />
                            <Vertex pos="1 1 3.33786e-006" />
                            <Vertex pos="1 -0.999992 0.5" />
                            <Vertex pos="1 -0.999992 3.09944e-006" />
                            <Vertex pos="-1 3 -2.38419e-007" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -2.99999 0" />
                            <Vertex pos="-1 -2.99999 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 -3200 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707106 -0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 3328 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 3.85501e-008 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 384 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242537 1.15651e-007 -0.970142 -0.242534" album="" material="bm_grid_blank1" texgens="-1 0 0 -1408 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="-52 68 -3" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 68 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.99998 -1.19209e-006" />
                            <Vertex pos="1 2.99999 -0.499999" />
                            <Vertex pos="1 -2.99998 -1.19209e-006" />
                            <Vertex pos="1 -2.99998 -0.499999" />
                            <Vertex pos="-1 0.999985 0.499999" />
                            <Vertex pos="-1 0.999992 9.53674e-007" />
                            <Vertex pos="-1 -0.999985 0.499999" />
                            <Vertex pos="-1 -0.999985 9.53674e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707105 0.707109 1.41614e-005 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707106 -0.707108 -0 -1.4142" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.242535" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="-54 66 -3" rot="1 0 0 0" scale="" transform="1 0 0 -54 0 1 0 66 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.5" />
                            <Vertex pos="0.999996 1 7.15256e-007" />
                            <Vertex pos="3 -1 4.76837e-007" />
                            <Vertex pos="3 -1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="-1 1 7.15256e-007" />
                            <Vertex pos="-3 -1 4.76837e-007" />
                            <Vertex pos="-3 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242535 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 -0.242535" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="-54 70 -3" rot="1 0 0 0" scale="" transform="1 0 0 -54 0 1 0 70 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 -4.76837e-007" />
                            <Vertex pos="2.99999 1 -0.5" />
                            <Vertex pos="0.999996 -1 0.5" />
                            <Vertex pos="0.999996 -1 2.38419e-007" />
                            <Vertex pos="-3 1 -4.76837e-007" />
                            <Vertex pos="-3 1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-0.999996 -1 2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="0.707106 -0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 1 0 -4736 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707106 -0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 -1 0 4864 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="-22 56 -1.75" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 56 0 0 1 -1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_C" texgens="1 0 0 2816 0 -1 0 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="-24 56 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 56 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2.38419e-007" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 -1 2.38419e-007" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -2.38419e-007" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 -3200 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 3328 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 384 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1408 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="-20 56 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 56 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -1.19209e-007" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 -1.19209e-007" />
                            <Vertex pos="-1 0.999996 3.57628e-007" />
                            <Vertex pos="-1 0.999996 -0.5" />
                            <Vertex pos="-1 -1 3.57628e-007" />
                            <Vertex pos="-1 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707106 0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242535 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="-22 54 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 54 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999987 1 -5.48363e-006" />
                            <Vertex pos="0.999985 1 -0.500001" />
                            <Vertex pos="2.99998 -1 0.500001" />
                            <Vertex pos="2.99999 -1 5.36442e-006" />
                            <Vertex pos="-0.999989 1 -5.48363e-006" />
                            <Vertex pos="-0.999987 1 -0.500001" />
                            <Vertex pos="-2.99998 -1 0.500001" />
                            <Vertex pos="-2.99999 -1 5.36442e-006" />
                        </Vertices>
                        <Face id="0" plane="0.707106 0.707107 1.41615e-005 -1.4142" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 -2.78172e-006 -1.41421" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242539 0.970142 -0.242533" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242539 -0.970142 -0.242533" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="-22 58 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 58 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.00001 1 0.499999" />
                            <Vertex pos="3.00001 1 -5.48363e-006" />
                            <Vertex pos="1 -1 5.36442e-006" />
                            <Vertex pos="1 -1 -0.499999" />
                            <Vertex pos="-3.00001 1 0.499999" />
                            <Vertex pos="-3.00001 1 -5.48363e-006" />
                            <Vertex pos="-1 -1 5.36442e-006" />
                            <Vertex pos="-1 -1 -0.499999" />
                        </Vertices>
                        <Face id="0" plane="0.707105 -0.707109 0 -1.41421" album="" material="bm_edge_white" texgens="0 1 0 -4736 0 0 -1 128.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707105 -0.707108 0 -1.41421" album="" material="bm_edge_white" texgens="0 -1 0 4864 0 0 -1 128.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 128.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 128.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242533 0.970143 -0.242538" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242533 -0.970143 -0.242538" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="198" owner="0" type="0" pos="-19 6 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 6 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 0.25" />
                            <Vertex pos="4 1 -0.25" />
                            <Vertex pos="4 -1 0.25" />
                            <Vertex pos="4 -1 -0.25" />
                            <Vertex pos="-4 1 0.25" />
                            <Vertex pos="-4 1 -0.25" />
                            <Vertex pos="-4 -1 0.25" />
                            <Vertex pos="-4 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2048 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile07_C" texgens="1 0 0 2048 0 -1 0 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -768 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="199" owner="0" type="0" pos="-24 1 -1" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 1 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 0.5" />
                            <Vertex pos="1 6 -5.96046e-008" />
                            <Vertex pos="1 -6 0.5" />
                            <Vertex pos="1 -6 -5.96046e-008" />
                            <Vertex pos="-1 8 1.19209e-007" />
                            <Vertex pos="-1 8 -0.5" />
                            <Vertex pos="-1 -8 1.19209e-007" />
                            <Vertex pos="-1 -8 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.94975" album="" material="bm_edge_white" texgens="-1 0 0 -1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -4.94975" album="" material="bm_edge_white" texgens="1 0 0 1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 -384 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -640 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="-14 6 -1" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 6 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 -1.19209e-007" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -3 -2.38419e-007" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 0.999998 0.5" />
                            <Vertex pos="-1 0.999998 4.76837e-007" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 -1 2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707106 0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="201" owner="0" type="0" pos="-17 4 -1" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 4 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.5" />
                            <Vertex pos="2 1 -2.38419e-007" />
                            <Vertex pos="4 -1 5.96046e-008" />
                            <Vertex pos="4 -1 -0.5" />
                            <Vertex pos="-4 1 0.5" />
                            <Vertex pos="-4 1 -2.38419e-007" />
                            <Vertex pos="-2 -1 5.96046e-008" />
                            <Vertex pos="-2 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -768 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="202" owner="0" type="0" pos="-19 8 -1" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 8 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 0" />
                            <Vertex pos="6 1 -0.5" />
                            <Vertex pos="4 -1 0.5" />
                            <Vertex pos="4 -1 5.96046e-008" />
                            <Vertex pos="-6 1 0" />
                            <Vertex pos="-6 1 -0.5" />
                            <Vertex pos="-4 -1 0.5" />
                            <Vertex pos="-4 -1 5.96046e-008" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -3.53553" album="" material="bm_edge_white" texgens="0 1 0 -4736 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -3.53553" album="" material="bm_edge_white" texgens="0 -1 0 4864 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -768 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="-22 0 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 0 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 5 0.25" />
                            <Vertex pos="1 5 -0.25" />
                            <Vertex pos="1 -5 0.25" />
                            <Vertex pos="1 -5 -0.25" />
                            <Vertex pos="-1 5 0.25" />
                            <Vertex pos="-1 5 -0.25" />
                            <Vertex pos="-1 -5 0.25" />
                            <Vertex pos="-1 -5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_edge_white" texgens="-1 0 0 -1152 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_edge_white" texgens="1 0 0 1280 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile07_C" texgens="1 0 0 1280 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -384 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="-22 -6 -1" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -6 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.5" />
                            <Vertex pos="1 1 0" />
                            <Vertex pos="3 -1 5.96046e-008" />
                            <Vertex pos="3 -1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="-1 1 0" />
                            <Vertex pos="-3 -1 5.96046e-008" />
                            <Vertex pos="-3 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 -128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -896 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="-20 -1 -1" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -1 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 5.96046e-008" />
                            <Vertex pos="1 4 -0.5" />
                            <Vertex pos="1 -6 5.96046e-008" />
                            <Vertex pos="1 -6 -0.5" />
                            <Vertex pos="-1 6 0.5" />
                            <Vertex pos="-1 6 -5.96046e-008" />
                            <Vertex pos="-1 -4 0.5" />
                            <Vertex pos="-1 -4 -5.96046e-008" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -3.53553" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -3.53553" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="0 76 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 76 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.25" />
                            <Vertex pos="1 3 -0.25" />
                            <Vertex pos="1 -3 0.25" />
                            <Vertex pos="1 -3 -0.25" />
                            <Vertex pos="-1 3 0.25" />
                            <Vertex pos="-1 3 -0.25" />
                            <Vertex pos="-1 -3 0.25" />
                            <Vertex pos="-1 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1792 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_C" texgens="1 0 0 2816 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="-2 76 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 76 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -3 0" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 5 0.5" />
                            <Vertex pos="-1 5 0" />
                            <Vertex pos="-1 -5 0.5" />
                            <Vertex pos="-1 -5 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -2.82843" album="" material="bm_edge_white" texgens="-1 0 0 -3200 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="1 0 0 3328 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 384 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1408 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="2 76 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 76 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 5 0.5" />
                            <Vertex pos="1 5 0" />
                            <Vertex pos="1 -5 0.5" />
                            <Vertex pos="1 -5 0" />
                            <Vertex pos="-1 3 0" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -3 0" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.82843" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="-2.38419e-007 72 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.38419e-007 0 1 0 72 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999983 1 4.76837e-007" />
                            <Vertex pos="0.999976 1 -0.5" />
                            <Vertex pos="2.99998 -1 0.5" />
                            <Vertex pos="2.99998 -1 -7.15256e-007" />
                            <Vertex pos="-0.999983 1 4.76837e-007" />
                            <Vertex pos="-0.999976 1 -0.5" />
                            <Vertex pos="-2.99998 -1 0.5" />
                            <Vertex pos="-2.99998 -1 -7.15256e-007" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707106 0 -1.4142" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707106 -9.94665e-006 -1.4142" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242535 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242535 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="210" owner="0" type="0" pos="3.8147e-006 80 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 3.8147e-006 0 1 0 80 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.00001 1 0.500002" />
                            <Vertex pos="3 1 -1.90735e-006" />
                            <Vertex pos="1.00001 -1 2.14577e-006" />
                            <Vertex pos="1 -1 -0.500002" />
                            <Vertex pos="-3.00001 1 0.500002" />
                            <Vertex pos="-3 1 -1.90735e-006" />
                            <Vertex pos="-1.00001 -1 2.14577e-006" />
                            <Vertex pos="-1.00001 -1 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="0.707109 -0.707105 -1.41613e-005 -1.41422" album="" material="bm_edge_white" texgens="0 1 0 -3712 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.70711 -0.707103 -1.41613e-005 -1.41423" album="" material="bm_edge_white" texgens="0 -1 0 3840 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -0.242538" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 -0.242538" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="-24 86 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 86 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 1 0.25" />
                            <Vertex pos="5 1 -0.25" />
                            <Vertex pos="5 -1 0.25" />
                            <Vertex pos="5 -1 -0.25" />
                            <Vertex pos="-5 1 0.25" />
                            <Vertex pos="-5 1 -0.25" />
                            <Vertex pos="-5 -1 0.25" />
                            <Vertex pos="-5 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -3712 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 3840 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile07_C" texgens="1 0 0 3840 0 -1 0 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1664 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="-30 85 -3" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 85 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.5" />
                            <Vertex pos="1 2 4.76837e-007" />
                            <Vertex pos="1 -7.62939e-006 0.5" />
                            <Vertex pos="1 -7.62939e-006 2.38419e-007" />
                            <Vertex pos="-1 2 -2.38419e-007" />
                            <Vertex pos="-1 2 -0.5" />
                            <Vertex pos="-1 -2.00001 -2.38419e-007" />
                            <Vertex pos="-1 -2.00001 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -3200 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707106 0 -0.707112" album="" material="bm_edge_white" texgens="1 0 0 3328 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 384 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 1.15649e-007 -0.970143 -0.242535" album="" material="bm_grid_blank1" texgens="-1 0 0 -1408 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="218" owner="0" type="0" pos="-18 85 -3" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 85 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 -2.38419e-007" />
                            <Vertex pos="1 2 -0.5" />
                            <Vertex pos="1 -2 4.76837e-007" />
                            <Vertex pos="1 -2 -0.5" />
                            <Vertex pos="-1 2 0.5" />
                            <Vertex pos="-1 2 -4.76837e-007" />
                            <Vertex pos="-1 0 0.5" />
                            <Vertex pos="-1 0 0" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4736 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -0.707107" album="" material="bm_edge_white" texgens="1 0 0 4864 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 1152 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -2176 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="-24 84 -3" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 84 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 1 0.5" />
                            <Vertex pos="5 1 -2.38419e-007" />
                            <Vertex pos="7 -1 -2.38419e-007" />
                            <Vertex pos="7 -1 -0.5" />
                            <Vertex pos="-4.99999 1 0.5" />
                            <Vertex pos="-4.99999 1 -2.38419e-007" />
                            <Vertex pos="-6.99999 -1 -2.38419e-007" />
                            <Vertex pos="-6.99999 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -4.24264" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -4.24263" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -3712 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 3840 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 640 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1664 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="-98 15 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -98 0 1 0 15 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 5.99999 0.500001" />
                            <Vertex pos="1 6 -7.15256e-007" />
                            <Vertex pos="1 -6 0.500001" />
                            <Vertex pos="1 -6 -7.15256e-007" />
                            <Vertex pos="-1 3.99999 9.53674e-007" />
                            <Vertex pos="-1 4 -0.500001" />
                            <Vertex pos="-1 -4 9.53674e-007" />
                            <Vertex pos="-1 -4 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707108 0.707105 1.41613e-005 -3.53552" album="" material="bm_edge_white" texgens="-1 0 0 -4736 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -3.53553" album="" material="bm_edge_white" texgens="1 0 0 4864 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242537" album="" material="bm_grid_blank2" texgens="1 0 0 1152 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -2176 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="-100 15 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 -100 0 1 0 15 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 4 0.25" />
                            <Vertex pos="-1 4 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -4736 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 4864 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_C" texgens="1 0 0 4864 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -2176 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="-102 20 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -102 0 1 0 20 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.00001 1 0.500001" />
                            <Vertex pos="5.00001 1 -9.53674e-007" />
                            <Vertex pos="3.00001 -1 2.38419e-007" />
                            <Vertex pos="3.00001 -1 -0.500001" />
                            <Vertex pos="-5 1 0.500001" />
                            <Vertex pos="-5 1 -9.53674e-007" />
                            <Vertex pos="-5 -1 2.38419e-007" />
                            <Vertex pos="-5 -1 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 1 0 -3712 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 3840 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -1152 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 1280 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 -640 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242537" album="" material="bm_grid_blank1" texgens="-1 0 0 -384 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="0" type="0" pos="-104 18 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 -104 0 1 0 18 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 0.25" />
                            <Vertex pos="3 1 -0.25" />
                            <Vertex pos="3 -1 0.25" />
                            <Vertex pos="3 -1 -0.25" />
                            <Vertex pos="-3 1 0.25" />
                            <Vertex pos="-3 1 -0.25" />
                            <Vertex pos="-3 -1 0.25" />
                            <Vertex pos="-3 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -4224 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 4352 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_C" texgens="1 0 0 4352 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1920 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="0" type="0" pos="-99 10 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -99 0 1 0 10 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 1 4.76837e-007" />
                            <Vertex pos="0 1 -0.5" />
                            <Vertex pos="2 -1 0.5" />
                            <Vertex pos="2 -1 2.38419e-007" />
                            <Vertex pos="-2 1 4.76837e-007" />
                            <Vertex pos="-2 1 -0.5" />
                            <Vertex pos="-2 -1 0.5" />
                            <Vertex pos="-2 -1 2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -0.707107" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242535 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 256 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1280 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="228" owner="0" type="0" pos="-56 -8 -1.75" rot="1 0 0 0" scale="" transform="1 0 0 -56 0 1 0 -8 0 0 1 -1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 1 0.25" />
                            <Vertex pos="7 1 -0.25" />
                            <Vertex pos="7 -1 0.25" />
                            <Vertex pos="7 -1 -0.25" />
                            <Vertex pos="-7 1 0.25" />
                            <Vertex pos="-7 1 -0.25" />
                            <Vertex pos="-7 -1 0.25" />
                            <Vertex pos="-7 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -4224 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 4352 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_C" texgens="1 0 0 4352 0 -1 0 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1920 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="229" owner="0" type="0" pos="-64 -8 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -64 0 1 0 -8 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2.38419e-007" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 -0.999999 2.38419e-007" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -2.38419e-007" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 -3200 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 3328 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 384 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1408 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="230" owner="0" type="0" pos="-48 -8 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -48 0 1 0 -8 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.99999 0.500001" />
                            <Vertex pos="1 3 -8.34465e-007" />
                            <Vertex pos="1 -2.99999 0.500001" />
                            <Vertex pos="1 -3 -8.34465e-007" />
                            <Vertex pos="-1 0.999994 9.53674e-007" />
                            <Vertex pos="-1 0.999997 -0.500001" />
                            <Vertex pos="-1 -0.99999 9.53674e-007" />
                            <Vertex pos="-1 -0.999996 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707109 0.707105 1.41612e-005 -1.4142" album="" material="bm_edge_white" texgens="-1 0 0 -5760 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707108 -0.707106 8.51362e-006 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 5888 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242537" album="" material="bm_grid_blank2" texgens="1 0 0 1664 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242537" album="" material="bm_grid_blank1" texgens="-1 0 0 -2688 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="231" owner="0" type="0" pos="-56 -10 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -56 0 1 0 -10 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 1 -1.19209e-007" />
                            <Vertex pos="7 1 -0.5" />
                            <Vertex pos="9 -1 0.5" />
                            <Vertex pos="9 -1 1.19209e-007" />
                            <Vertex pos="-7 1 -1.19209e-007" />
                            <Vertex pos="-7 1 -0.5" />
                            <Vertex pos="-9 -1 0.5" />
                            <Vertex pos="-9 -1 1.19209e-007" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -5.65685" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -5.65685" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -4224 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 4352 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 896 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1920 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="232" owner="0" type="0" pos="-56 -6 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -56 0 1 0 -6 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 1 0.5" />
                            <Vertex pos="9 1 1.19209e-007" />
                            <Vertex pos="7 -1 -1.19209e-007" />
                            <Vertex pos="7 -1 -0.5" />
                            <Vertex pos="-9 1 0.5" />
                            <Vertex pos="-9 1 1.19209e-007" />
                            <Vertex pos="-7 -1 -1.19209e-007" />
                            <Vertex pos="-7 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -5.65685" album="" material="bm_edge_white" texgens="0 1 0 -4736 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -5.65685" album="" material="bm_edge_white" texgens="0 -1 0 4864 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -4224 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 4352 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 896 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1920 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="238" owner="0" type="0" pos="-46 16 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 -46 0 1 0 16 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_C" texgens="1 0 0 2816 0 -1 0 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="239" owner="0" type="0" pos="-48 16 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -48 0 1 0 16 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2.38419e-007" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 -1 2.38419e-007" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -2.38419e-007" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 -3200 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 3328 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 384 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1408 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="240" owner="0" type="0" pos="-44 16 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -44 0 1 0 16 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -2.38419e-007" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 -2.38419e-007" />
                            <Vertex pos="-1 1 2.38419e-007" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 -0.999996 2.38419e-007" />
                            <Vertex pos="-1 -0.999999 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707108 -0.707106 4.21468e-006 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="241" owner="0" type="0" pos="-46 14 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -46 0 1 0 14 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="3 -1 0.5" />
                            <Vertex pos="3 -1 2.38419e-007" />
                            <Vertex pos="-0.999996 1 0" />
                            <Vertex pos="-0.999996 1 -0.5" />
                            <Vertex pos="-3 -1 0.5" />
                            <Vertex pos="-3 -1 2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707106 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="242" owner="0" type="0" pos="-46 18 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -46 0 1 0 18 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 0.500001" />
                            <Vertex pos="3 1 -9.53674e-007" />
                            <Vertex pos="1 -1 9.53674e-007" />
                            <Vertex pos="1 -1 -0.500001" />
                            <Vertex pos="-3 1 0.500001" />
                            <Vertex pos="-3 1 -9.53674e-007" />
                            <Vertex pos="-1 -1 9.53674e-007" />
                            <Vertex pos="-1 -1 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 1 0 -4736 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 -1 0 4864 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -0.242537" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242537" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="275" owner="0" type="0" pos="-14 34.75 4" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 34.75 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 1" />
                            <Vertex pos="1 0.25 -1" />
                            <Vertex pos="1 -0.25 1" />
                            <Vertex pos="1 -0.25 -1" />
                            <Vertex pos="-1 0.25 1" />
                            <Vertex pos="-1 0.25 -1" />
                            <Vertex pos="-1 -0.25 1" />
                            <Vertex pos="-1 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="1 0 -1.5 160 0 0 -1 64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 4864 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="276" owner="0" type="0" pos="-18 29.25 4" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 29.25 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 1" />
                            <Vertex pos="1 0.25 -1" />
                            <Vertex pos="1 -0.25 1" />
                            <Vertex pos="1 -0.25 -1" />
                            <Vertex pos="-1 0.25 1" />
                            <Vertex pos="-1 0.25 -1" />
                            <Vertex pos="-1 -0.25 1" />
                            <Vertex pos="-1 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 1.5 160 0 0 -1 64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 4864 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="277" owner="0" type="0" pos="-78.75 26 2" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 26 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 1" />
                            <Vertex pos="0.25 1 -1" />
                            <Vertex pos="0.25 -1 1" />
                            <Vertex pos="0.25 -1 -1" />
                            <Vertex pos="-0.25 1 1" />
                            <Vertex pos="-0.25 1 -1" />
                            <Vertex pos="-0.25 -1 1" />
                            <Vertex pos="-0.25 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="0 1 1.5 160 0 0 -1 64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="278" owner="0" type="0" pos="-51.25 26 2" rot="1 0 0 0" scale="" transform="1 0 0 -51.25 0 1 0 26 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 1" />
                            <Vertex pos="0.25 1 -1" />
                            <Vertex pos="0.25 -1 1" />
                            <Vertex pos="0.25 -1 -1" />
                            <Vertex pos="-0.25 1 1" />
                            <Vertex pos="-0.25 1 -1" />
                            <Vertex pos="-0.25 -1 1" />
                            <Vertex pos="-0.25 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="0 -1 -1.5 160 0 0 -1 64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="367" owner="0" type="0" pos="2 25 -1.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 25 0 0 1 -1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 2 0.25" />
                            <Vertex pos="9 2 -0.25" />
                            <Vertex pos="9 -2 0.25" />
                            <Vertex pos="9 -2 -0.25" />
                            <Vertex pos="-9 2 0.25" />
                            <Vertex pos="-9 2 -0.25" />
                            <Vertex pos="-9 -2 0.25" />
                            <Vertex pos="-9 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_edge_white" texgens="0 1 0 -1920 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_edge_white" texgens="0 -1 0 2048 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4736 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 4864 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_C" texgens="1 0 0 4864 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -2176 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="368" owner="0" type="0" pos="-8 25 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 25 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 -1.19209e-007" />
                            <Vertex pos="1 2 -0.5" />
                            <Vertex pos="1 -2 -1.19209e-007" />
                            <Vertex pos="1 -2 -0.5" />
                            <Vertex pos="-1 4 0.5" />
                            <Vertex pos="-1 4 1.19209e-007" />
                            <Vertex pos="-1 -4 0.5" />
                            <Vertex pos="-1 -4 1.19209e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 -3200 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="1 0 0 3328 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 384 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1408 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="369" owner="0" type="0" pos="12 25 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 25 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.5" />
                            <Vertex pos="1 4 2.38419e-007" />
                            <Vertex pos="1 -4 0.5" />
                            <Vertex pos="1 -4 2.38419e-007" />
                            <Vertex pos="-1 2 -3.57628e-007" />
                            <Vertex pos="-1 2 -0.5" />
                            <Vertex pos="-1 -2 -3.57628e-007" />
                            <Vertex pos="-1 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 -6784 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.12132" album="" material="bm_edge_white" texgens="1 0 0 6912 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 2176 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -3200 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="370" owner="0" type="0" pos="2 22 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 22 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 1 -3.57628e-006" />
                            <Vertex pos="9 1 -0.500003" />
                            <Vertex pos="11 -1 0.500003" />
                            <Vertex pos="11 -1 -3.57628e-006" />
                            <Vertex pos="-9 1 -6.67572e-006" />
                            <Vertex pos="-9 1 -0.499998" />
                            <Vertex pos="-11 -1 0.5" />
                            <Vertex pos="-11 -1 2.6226e-006" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -7.07107" album="" material="bm_edge_white" texgens="0 1 0 -2176 0 0 -1 127.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -7.07107" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 127.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -4736 0 0 -1 127.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 4864 0 0 -1 127.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-1.6705e-007 0.242539 0.970142 -0.242534" album="" material="bm_grid_blank2" texgens="1 0 0 1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-2.73354e-007 -0.242536 -0.970142 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -2176 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="371" owner="0" type="0" pos="2 28 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 28 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="11 1 0.5" />
                            <Vertex pos="11 1 7.15256e-007" />
                            <Vertex pos="9 -1 -7.15256e-007" />
                            <Vertex pos="9 -1 -0.5" />
                            <Vertex pos="-11 1 0.5" />
                            <Vertex pos="-11 1 7.15256e-007" />
                            <Vertex pos="-9 -1 -7.15256e-007" />
                            <Vertex pos="-9 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -7.07107" album="" material="bm_edge_white" texgens="0 1 0 -4224 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -7.07107" album="" material="bm_edge_white" texgens="0 -1 0 4352 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -4736 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 4864 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -0.242535" album="" material="bm_grid_blank2" texgens="1 0 0 1152 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 -0.242535" album="" material="bm_grid_blank1" texgens="-1 0 0 -2176 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="380" owner="0" type="0" pos="-81 41 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 41 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 2560 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile07_C" texgens="1 0 0 2560 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -1024 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="381" owner="0" type="0" pos="-84 41 -3" rot="1 0 0 0" scale="" transform="1 0 0 -84 0 1 0 41 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.5" />
                            <Vertex pos="1 4 -2.38419e-007" />
                            <Vertex pos="1 -4 0.5" />
                            <Vertex pos="1 -4.00001 -2.38419e-007" />
                            <Vertex pos="-1 6 2.38419e-007" />
                            <Vertex pos="-1 6 -0.5" />
                            <Vertex pos="-1 -6 2.38419e-007" />
                            <Vertex pos="-1 -6.00001 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -3.53553" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707105 -0.707109 1.41614e-005 -3.53555" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="382" owner="0" type="0" pos="-78 41 -3" rot="1 0 0 0" scale="" transform="1 0 0 -78 0 1 0 41 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 2.38419e-007" />
                            <Vertex pos="1 6 -0.5" />
                            <Vertex pos="1 -6 2.38419e-007" />
                            <Vertex pos="1 -6 -0.5" />
                            <Vertex pos="-1 4 0.5" />
                            <Vertex pos="-1 4 -2.38419e-007" />
                            <Vertex pos="-1 -4 0.5" />
                            <Vertex pos="-1 -4 -2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -3.53553" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -3.53553" album="" material="bm_edge_white" texgens="1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1152 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="383" owner="0" type="0" pos="-81 36 -3" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 36 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.5" />
                            <Vertex pos="2 1 0" />
                            <Vertex pos="4 -1 0" />
                            <Vertex pos="4 -1 -0.5" />
                            <Vertex pos="-2 1 0.5" />
                            <Vertex pos="-2 1 0" />
                            <Vertex pos="-4 -1 0" />
                            <Vertex pos="-4 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 1 0 -3712 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 -1 0 3840 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1024 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="384" owner="0" type="0" pos="-81 46 -3" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 46 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 0" />
                            <Vertex pos="4 1 -0.5" />
                            <Vertex pos="2 -1 0.5" />
                            <Vertex pos="2 -1 0" />
                            <Vertex pos="-4 1 0" />
                            <Vertex pos="-4 1 -0.5" />
                            <Vertex pos="-2 -1 0.5" />
                            <Vertex pos="-2 -1 0" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 1 0 -4736 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 -1 0 4864 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 -1024 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="385" owner="0" type="0" pos="10.5 90 -3" rot="1 0 0 0" scale="" transform="1 0 0 10.5 0 1 0 90 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 0.500001" />
                            <Vertex pos="0.5 1 -9.53674e-007" />
                            <Vertex pos="0.5 -1 9.53674e-007" />
                            <Vertex pos="0.5 -1 -0.500001" />
                            <Vertex pos="-0.5 1 0.500001" />
                            <Vertex pos="-0.5 1 -9.53674e-007" />
                            <Vertex pos="-0.5 -1 9.53674e-007" />
                            <Vertex pos="-0.5 -1 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242537" album="Blasted" material="bm_stripe_caution2" texgens="1 1 0 11648 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242537" album="" material="bm_grid_blank1" texgens="-1 0 0 1088 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="388" owner="0" type="0" pos="9.5 90 -3" rot="1 0 0 0" scale="" transform="1 0 0 9.5 0 1 0 90 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 0.500001" />
                            <Vertex pos="0.5 1 -9.53674e-007" />
                            <Vertex pos="0.5 -1 9.53674e-007" />
                            <Vertex pos="0.5 -1 -0.500001" />
                            <Vertex pos="-0.5 1 0.500001" />
                            <Vertex pos="-0.5 1 -9.53674e-007" />
                            <Vertex pos="-0.5 -1 9.53674e-007" />
                            <Vertex pos="-0.5 -1 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242537" album="Blasted" material="bm_stripe_caution2" texgens="1 -1 0 192 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242537" album="" material="bm_grid_blank1" texgens="-1 0 0 1216 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="389" owner="0" type="0" pos="-31.5 -14 -1" rot="1 0 0 0" scale="" transform="1 0 0 -31.5 0 1 0 -14 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -1 0.5" />
                            <Vertex pos="0.5 -1 1.19209e-007" />
                            <Vertex pos="-0.5 -1 0.5" />
                            <Vertex pos="-0.5 -1 1.19209e-007" />
                            <Vertex pos="0.5 1 -1.19209e-007" />
                            <Vertex pos="0.5 1 -0.5" />
                            <Vertex pos="-0.5 1 0" />
                            <Vertex pos="-0.5 1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -4224 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="1.1565e-007 0.242536 0.970143 -0.242536" album="Blasted" material="bm_stripe_caution2" texgens="1 -1 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 -0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 1088 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-1 -0 -0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -4096 0 0 1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="1 0 0 1792 0 0 1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="391" owner="0" type="0" pos="-46 -24.5 -0.999999" rot="1 0 0 0" scale="" transform="1 0 0 -46 0 1 0 -24.5 0 0 1 -0.999999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 0.5" />
                            <Vertex pos="1 0.5 -4.17233e-007" />
                            <Vertex pos="1 -0.5 0.5" />
                            <Vertex pos="1 -0.5 -4.17233e-007" />
                            <Vertex pos="-1 0.5 4.76837e-007" />
                            <Vertex pos="-1 0.5 -0.5" />
                            <Vertex pos="-1 -0.5 4.76837e-007" />
                            <Vertex pos="-1 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -4352 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4480 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242535 0 0.970143 -0.242536" album="Blasted" material="bm_stripe_caution2" texgens="1 -1 0 0 0 -1 0 1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242535 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 -1 0 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="393" owner="0" type="0" pos="-56 -24.5 -1" rot="1 0 0 0" scale="" transform="1 0 0 -56 0 1 0 -24.5 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 0" />
                            <Vertex pos="1 0.5 -0.5" />
                            <Vertex pos="1 -0.5 0" />
                            <Vertex pos="1 -0.5 -0.5" />
                            <Vertex pos="-1 0.5 0.5" />
                            <Vertex pos="-1 0.5 0" />
                            <Vertex pos="-1 -0.5 0.5" />
                            <Vertex pos="-1 -0.5 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -4352 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4480 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 4480 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -4352 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="Blasted" material="bm_stripe_caution2" texgens="1 1 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 2432 0 -1 0 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="395" owner="0" type="0" pos="-46 -23.5 -0.999999" rot="1 0 0 0" scale="" transform="1 0 0 -46 0 1 0 -23.5 0 0 1 -0.999999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 0.5" />
                            <Vertex pos="1 0.5 -4.17233e-007" />
                            <Vertex pos="1 -0.5 0.5" />
                            <Vertex pos="1 -0.5 -4.17233e-007" />
                            <Vertex pos="-1 0.5 4.76837e-007" />
                            <Vertex pos="-1 0.5 -0.5" />
                            <Vertex pos="-1 -0.5 4.76837e-007" />
                            <Vertex pos="-1 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -4096 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4224 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242535 0 0.970143 -0.242536" album="Blasted" material="bm_stripe_caution2" texgens="1 1 0 0 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242535 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 -1 0 2112 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="397" owner="0" type="0" pos="-56 -23.5 -1" rot="1 0 0 0" scale="" transform="1 0 0 -56 0 1 0 -23.5 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 0" />
                            <Vertex pos="1 0.5 -0.5" />
                            <Vertex pos="1 -0.5 0" />
                            <Vertex pos="1 -0.5 -0.5" />
                            <Vertex pos="-1 0.5 0.5" />
                            <Vertex pos="-1 0.5 0" />
                            <Vertex pos="-1 -0.5 0.5" />
                            <Vertex pos="-1 -0.5 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -4096 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4224 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 4480 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -4352 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="Blasted" material="bm_stripe_caution2" texgens="1 -1 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 2432 0 -1 0 2112 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="399" owner="0" type="0" pos="-32.5 -14 -1" rot="1 0 0 0" scale="" transform="1 0 0 -32.5 0 1 0 -14 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -1 0.5" />
                            <Vertex pos="0.5 -1 1.19209e-007" />
                            <Vertex pos="-0.5 -1 0.5" />
                            <Vertex pos="-0.5 -1 1.19209e-007" />
                            <Vertex pos="0.5 1 -1.19209e-007" />
                            <Vertex pos="0.5 1 -0.5" />
                            <Vertex pos="-0.5 1 0" />
                            <Vertex pos="-0.5 1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -4224 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="1.1565e-007 0.242536 0.970143 -0.242536" album="Blasted" material="bm_stripe_caution2" texgens="1 1 0 192 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 -0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 1216 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-1 -0 -0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -4096 0 0 1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="401" owner="0" type="0" pos="-103 -7 19" rot="1 0 0 0" scale="" transform="1 0 0 -103 0 1 0 -7 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 -6" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 -6" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 -6" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 -6" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="402" owner="0" type="0" pos="-103 37 19" rot="1 0 0 0" scale="" transform="1 0 0 -103 0 1 0 37 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 2" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 2" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 2" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 2" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="403" owner="0" type="0" pos="-109 37 19" rot="1 0 0 0" scale="" transform="1 0 0 -109 0 1 0 37 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 2" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 2" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 2" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 2" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="404" owner="0" type="0" pos="-109 73 19" rot="1 0 0 0" scale="" transform="1 0 0 -109 0 1 0 73 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 -2" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 -2" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 -2" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 -2" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="405" owner="0" type="0" pos="-65 73 19" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 73 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 2" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 2" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 2" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 2" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="406" owner="0" type="0" pos="-65 111 19" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 111 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 2" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 2" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 2" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 2" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="407" owner="0" type="0" pos="-13 111 19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 111 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 -2" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 -2" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 -2" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 -2" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="408" owner="0" type="0" pos="-13 127 19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 127 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 -6" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 -6" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 -6" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 -6" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="409" owner="0" type="0" pos="15 127 19" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 127 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 2" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 2" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 2" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 2" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="410" owner="0" type="0" pos="15 71 19" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 71 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 -6" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 -6" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 -6" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 -6" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="411" owner="0" type="0" pos="37 71 19" rot="1 0 0 0" scale="" transform="1 0 0 37 0 1 0 71 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 -2" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 -2" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 -2" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 -2" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="412" owner="0" type="0" pos="37 35 19" rot="1 0 0 0" scale="" transform="1 0 0 37 0 1 0 35 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 2" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 2" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 2" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 2" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="413" owner="0" type="0" pos="13 35 19" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 35 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 -6" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 -6" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 -6" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 -6" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="414" owner="0" type="0" pos="13 9 19" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 9 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 -2" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 -2" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 -2" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 -2" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="415" owner="0" type="0" pos="-27 9 19" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 9 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 -2" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 -2" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 -2" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 -2" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="416" owner="0" type="0" pos="-27 -7 19" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 -7 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20 -6" />
                            <Vertex pos="2 -20 -10" />
                            <Vertex pos="2 -24 -6" />
                            <Vertex pos="2 -24 -10" />
                            <Vertex pos="-2 -20 -6" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 -6" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="589" owner="0" type="0" pos="28.75 35 7" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 35 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2" />
                            <Vertex pos="0.25 2 -2" />
                            <Vertex pos="0.25 0 2" />
                            <Vertex pos="0.25 0 -2" />
                            <Vertex pos="-0.25 2 2" />
                            <Vertex pos="-0.25 2 -2" />
                            <Vertex pos="-0.25 0 2" />
                            <Vertex pos="-0.25 0 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="0 -1 1.5 256 0 0 -1 128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="590" owner="0" type="0" pos="28.75 25 7" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 25 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2" />
                            <Vertex pos="0.25 2 -2" />
                            <Vertex pos="0.25 0 2" />
                            <Vertex pos="0.25 0 -2" />
                            <Vertex pos="-0.25 2 2" />
                            <Vertex pos="-0.25 2 -2" />
                            <Vertex pos="-0.25 0 2" />
                            <Vertex pos="-0.25 0 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="0 -1 -1.5 320 0 0 -1 128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="591" owner="0" type="0" pos="28.75 23 7" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 23 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2" />
                            <Vertex pos="0.25 2 -2" />
                            <Vertex pos="0.25 0 2" />
                            <Vertex pos="0.25 0 -2" />
                            <Vertex pos="-0.25 2 2" />
                            <Vertex pos="-0.25 2 -2" />
                            <Vertex pos="-0.25 0 2" />
                            <Vertex pos="-0.25 0 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="0 -1 1.5 256 0 0 -1 128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="592" owner="0" type="0" pos="-58.75 79 5" rot="1 0 0 0" scale="" transform="1 0 0 -58.75 0 1 0 79 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0 2" />
                            <Vertex pos="0.25 0 -2" />
                            <Vertex pos="0.25 -2 2" />
                            <Vertex pos="0.25 -2 -2" />
                            <Vertex pos="-0.25 0 2" />
                            <Vertex pos="-0.25 0 -2" />
                            <Vertex pos="-0.25 -2 2" />
                            <Vertex pos="-0.25 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="0 1 -1.5 320 0 0 -1 128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="593" owner="0" type="0" pos="-97 40.75 5" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 40.75 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 0.25 2" />
                            <Vertex pos="0 0.25 -2" />
                            <Vertex pos="0 -0.25 2" />
                            <Vertex pos="0 -0.25 -2" />
                            <Vertex pos="-2 0.25 2" />
                            <Vertex pos="-2 0.25 -2" />
                            <Vertex pos="-2 -0.25 2" />
                            <Vertex pos="-2 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="1 0 -1.5 320 0 0 -1 128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 4608 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="594" owner="0" type="0" pos="-97.5 -14 -1" rot="1 0 0 0" scale="" transform="1 0 0 -97.5 0 1 0 -14 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -1 0.5" />
                            <Vertex pos="0.5 -1 1.19209e-007" />
                            <Vertex pos="-0.5 -1 0.5" />
                            <Vertex pos="-0.5 -1 1.19209e-007" />
                            <Vertex pos="0.5 1 -1.19209e-007" />
                            <Vertex pos="0.5 1 -0.5" />
                            <Vertex pos="-0.5 1 0" />
                            <Vertex pos="-0.5 1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -4224 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="1.1565e-007 0.242536 0.970143 -0.242536" album="Blasted" material="bm_stripe_caution2" texgens="1 -1 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 -0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 1088 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-1 -0 -0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -4096 0 0 1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="1 0 0 1792 0 0 1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="595" owner="0" type="0" pos="-98.5 -14 -1" rot="1 0 0 0" scale="" transform="1 0 0 -98.5 0 1 0 -14 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -1 0.5" />
                            <Vertex pos="0.5 -1 1.19209e-007" />
                            <Vertex pos="-0.5 -1 0.5" />
                            <Vertex pos="-0.5 -1 1.19209e-007" />
                            <Vertex pos="0.5 1 -1.19209e-007" />
                            <Vertex pos="0.5 1 -0.5" />
                            <Vertex pos="-0.5 1 0" />
                            <Vertex pos="-0.5 1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -4224 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="1.1565e-007 0.242536 0.970143 -0.242536" album="Blasted" material="bm_stripe_caution2" texgens="1 1 0 192 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 -0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 1216 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-1 -0 -0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -4096 0 0 1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="596" owner="0" type="0" pos="-74 -24.5 -0.999999" rot="1 0 0 0" scale="" transform="1 0 0 -74 0 1 0 -24.5 0 0 1 -0.999999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 0.5" />
                            <Vertex pos="1 0.5 -4.17233e-007" />
                            <Vertex pos="1 -0.5 0.5" />
                            <Vertex pos="1 -0.5 -4.17233e-007" />
                            <Vertex pos="-1 0.5 4.76837e-007" />
                            <Vertex pos="-1 0.5 -0.5" />
                            <Vertex pos="-1 -0.5 4.76837e-007" />
                            <Vertex pos="-1 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -4352 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4480 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242535 0 0.970143 -0.242536" album="Blasted" material="bm_stripe_caution2" texgens="1 -1 0 0 0 -1 0 1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242535 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 -1 0 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="597" owner="0" type="0" pos="-74 -23.5 -0.999999" rot="1 0 0 0" scale="" transform="1 0 0 -74 0 1 0 -23.5 0 0 1 -0.999999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 0.5" />
                            <Vertex pos="1 0.5 -4.17233e-007" />
                            <Vertex pos="1 -0.5 0.5" />
                            <Vertex pos="1 -0.5 -4.17233e-007" />
                            <Vertex pos="-1 0.5 4.76837e-007" />
                            <Vertex pos="-1 0.5 -0.5" />
                            <Vertex pos="-1 -0.5 4.76837e-007" />
                            <Vertex pos="-1 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -4096 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4224 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242535 0 0.970143 -0.242536" album="Blasted" material="bm_stripe_caution2" texgens="1 1 0 0 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242535 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 -1 0 2112 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="598" owner="0" type="0" pos="-84 -24.5 -1" rot="1 0 0 0" scale="" transform="1 0 0 -84 0 1 0 -24.5 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 0" />
                            <Vertex pos="1 0.5 -0.5" />
                            <Vertex pos="1 -0.5 0" />
                            <Vertex pos="1 -0.5 -0.5" />
                            <Vertex pos="-1 0.5 0.5" />
                            <Vertex pos="-1 0.5 0" />
                            <Vertex pos="-1 -0.5 0.5" />
                            <Vertex pos="-1 -0.5 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -4352 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4480 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 4480 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -4352 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="Blasted" material="bm_stripe_caution2" texgens="1 1 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 2432 0 -1 0 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="599" owner="0" type="0" pos="-84 -23.5 -1" rot="1 0 0 0" scale="" transform="1 0 0 -84 0 1 0 -23.5 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 0" />
                            <Vertex pos="1 0.5 -0.5" />
                            <Vertex pos="1 -0.5 0" />
                            <Vertex pos="1 -0.5 -0.5" />
                            <Vertex pos="-1 0.5 0.5" />
                            <Vertex pos="-1 0.5 0" />
                            <Vertex pos="-1 -0.5 0.5" />
                            <Vertex pos="-1 -0.5 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -4096 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4224 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 4480 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -4352 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="Blasted" material="bm_stripe_caution2" texgens="1 -1 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank1" texgens="-1 0 0 2432 0 -1 0 2112 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="600" owner="0" type="0" pos="-7.5 90 -3" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 90 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 0.500001" />
                            <Vertex pos="0.5 1 -9.53674e-007" />
                            <Vertex pos="0.5 -1 9.53674e-007" />
                            <Vertex pos="0.5 -1 -0.500001" />
                            <Vertex pos="-0.5 1 0.500001" />
                            <Vertex pos="-0.5 1 -9.53674e-007" />
                            <Vertex pos="-0.5 -1 9.53674e-007" />
                            <Vertex pos="-0.5 -1 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242537" album="Blasted" material="bm_stripe_caution2" texgens="1 1 0 11648 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242537" album="" material="bm_grid_blank1" texgens="-1 0 0 1088 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="601" owner="0" type="0" pos="-8.5 90 -3" rot="1 0 0 0" scale="" transform="1 0 0 -8.5 0 1 0 90 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 0.500001" />
                            <Vertex pos="0.5 1 -9.53674e-007" />
                            <Vertex pos="0.5 -1 9.53674e-007" />
                            <Vertex pos="0.5 -1 -0.500001" />
                            <Vertex pos="-0.5 1 0.500001" />
                            <Vertex pos="-0.5 1 -9.53674e-007" />
                            <Vertex pos="-0.5 -1 9.53674e-007" />
                            <Vertex pos="-0.5 -1 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242537" album="Blasted" material="bm_stripe_caution2" texgens="1 -1 0 192 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242537" album="" material="bm_grid_blank1" texgens="-1 0 0 1216 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="602" owner="0" type="0" pos="-35 17 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 17 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 0 0.25" />
                            <Vertex pos="4 0 -0.25" />
                            <Vertex pos="2 2 0.75" />
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 0 0.75" />
                            <Vertex pos="2 0 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -1.21268" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 0.727607" album="" material="bm_grid_blank1" texgens="-1 0 0 512 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="603" owner="0" type="0" pos="-37 17 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 17 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 0 0.25" />
                            <Vertex pos="4 0 -0.25" />
                            <Vertex pos="0 2 1.75" />
                            <Vertex pos="0 2 1.25" />
                            <Vertex pos="0 0 1.75" />
                            <Vertex pos="0 0 1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.351123 0 0.936329 -1.63858" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.351123 0 -0.936329 1.17041" album="" material="bm_grid_blank1" texgens="-1 0 0 512 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="604" owner="0" type="0" pos="-41 17 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -41 0 1 0 17 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 0 0.25" />
                            <Vertex pos="4 0 -0.25" />
                            <Vertex pos="2 2 0.75" />
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 0 0.75" />
                            <Vertex pos="2 0 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -1.21268" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 0.727607" album="" material="bm_grid_blank1" texgens="-1 0 0 512 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="605" owner="0" type="0" pos="-43 17 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 17 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 0 0.25" />
                            <Vertex pos="4 0 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 0 0.25" />
                            <Vertex pos="-2 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 512 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="606" owner="0" type="0" pos="-43 15 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 15 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 2 0.25" />
                            <Vertex pos="0 2 -0.25" />
                            <Vertex pos="0 -2 0.25" />
                            <Vertex pos="0 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 512 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="607" owner="0" type="0" pos="-43 11 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 11 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 2 0.25" />
                            <Vertex pos="0 2 -0.25" />
                            <Vertex pos="0 -2 -0.25" />
                            <Vertex pos="0 -2 -0.75" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                            <Vertex pos="-2 -2 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.124035 0.992278 -0" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.124035 -0.992278 -0.496139" album="" material="bm_grid_blank1" texgens="-1 0 0 512 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="608" owner="0" type="0" pos="-43 1 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 1 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 4 0.25" />
                            <Vertex pos="0 4 -0.25" />
                            <Vertex pos="0 0 -0.25" />
                            <Vertex pos="0 0 -0.75" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 0 -0.25" />
                            <Vertex pos="-2 0 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.124035 0.992278 0.248069" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.124035 -0.992278 -0.744208" album="" material="bm_grid_blank1" texgens="-1 0 0 512 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="609" owner="0" type="0" pos="-43 9 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 9 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 0 0.25" />
                            <Vertex pos="0 0 -0.25" />
                            <Vertex pos="0 -4 -1.25" />
                            <Vertex pos="0 -4 -1.75" />
                            <Vertex pos="-2 0 0.25" />
                            <Vertex pos="-2 0 -0.25" />
                            <Vertex pos="-2 -4 -1.25" />
                            <Vertex pos="-2 -4 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.351123 0.936329 -0.234082" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.351123 -0.936329 -0.234082" album="" material="bm_grid_blank1" texgens="-1 0 0 512 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="610" owner="0" type="0" pos="-31 45 -1.75" rot="1 0 0 0" scale="" transform="1 0 0 -31 0 1 0 45 0 0 1 -1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 2 1.25" />
                            <Vertex pos="-4 2 0.75" />
                            <Vertex pos="-4 -2 1.25" />
                            <Vertex pos="-4 -2 0.75" />
                            <Vertex pos="-8 2 1.25" />
                            <Vertex pos="-8 2 0.75" />
                            <Vertex pos="-8 -2 1.25" />
                            <Vertex pos="-8 -2 0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.25" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 0.75" album="" material="bm_grid_blank1" texgens="-1 0 0 512 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="611" owner="0" type="0" pos="-27 45 -1.75" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 45 0 0 1 -1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 2 0.75" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-4 -2 0.75" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-8 2 1.25" />
                            <Vertex pos="-8 2 0.75" />
                            <Vertex pos="-8 -2 1.25" />
                            <Vertex pos="-8 -2 0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.124035 0 0.992278 -0.24807" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.124035 0 -0.992278 -0.248069" album="" material="bm_grid_blank1" texgens="-1 0 0 512 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="612" owner="0" type="0" pos="-45.25 16.5 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -45.25 0 1 0 16.5 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3.5 0.25" />
                            <Vertex pos="0.25 -3.5 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3.5 0.25" />
                            <Vertex pos="-0.25 -3.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="613" owner="0" type="0" pos="-42.75 16.5 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -42.75 0 1 0 16.5 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0 0.25" />
                            <Vertex pos="0.25 0 -0.25" />
                            <Vertex pos="0.25 -3.5 0.25" />
                            <Vertex pos="0.25 -3.5 -0.25" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -3.5 0.25" />
                            <Vertex pos="-0.25 -3.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="614" owner="0" type="0" pos="-42.75 17 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -42.75 0 1 0 17 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.75 0 0.25" />
                            <Vertex pos="3.75 0 -0.25" />
                            <Vertex pos="3.75 -0.5 0.25" />
                            <Vertex pos="3.75 -0.5 -0.25" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="615" owner="0" type="0" pos="-42.75 19.5 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -42.75 0 1 0 19.5 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.75 0 0.25" />
                            <Vertex pos="3.75 0 -0.25" />
                            <Vertex pos="3.75 -0.5 0.25" />
                            <Vertex pos="3.75 -0.5 -0.25" />
                            <Vertex pos="-2.25 0 0.25" />
                            <Vertex pos="-2.25 0 -0.25" />
                            <Vertex pos="-2.25 -0.5 0.25" />
                            <Vertex pos="-2.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="616" owner="0" type="0" pos="-38.75 17 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -38.75 0 1 0 17 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0 -0.25" />
                            <Vertex pos="1.75 0 -0.75" />
                            <Vertex pos="1.75 -0.5 -0.25" />
                            <Vertex pos="1.75 -0.5 -0.75" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -320 -0.25 0 -1 48 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.181902" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.30317" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="617" owner="0" type="0" pos="-38.75 19.5 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -38.75 0 1 0 19.5 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0 -0.25" />
                            <Vertex pos="1.75 0 -0.75" />
                            <Vertex pos="1.75 -0.5 -0.25" />
                            <Vertex pos="1.75 -0.5 -0.75" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 64 -0.25 0 -1 48 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.181902" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.30317" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="618" owner="0" type="0" pos="-32.75 17 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -32.75 0 1 0 17 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0 -0.25" />
                            <Vertex pos="1.75 0 -0.75" />
                            <Vertex pos="1.75 -0.5 -0.25" />
                            <Vertex pos="1.75 -0.5 -0.75" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -320 -0.25 0 -1 48 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.181902" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.30317" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="619" owner="0" type="0" pos="-32.75 19.5 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -32.75 0 1 0 19.5 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0 -0.25" />
                            <Vertex pos="1.75 0 -0.75" />
                            <Vertex pos="1.75 -0.5 -0.25" />
                            <Vertex pos="1.75 -0.5 -0.75" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 64 -0.25 0 -1 48 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.181902" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.30317" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="620" owner="0" type="0" pos="-36.75 17 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -36.75 0 1 0 17 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.75 0 -1.25" />
                            <Vertex pos="3.75 0 -1.75" />
                            <Vertex pos="3.75 -0.5 -1.25" />
                            <Vertex pos="3.75 -0.5 -1.75" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -832 -0.375 0 -1 40 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.351123 0 0.936329 -0.146301" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.351123 0 -0.936329 -0.321863" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="621" owner="0" type="0" pos="-36.75 19.5 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -36.75 0 1 0 19.5 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.75 0 -1.25" />
                            <Vertex pos="3.75 0 -1.75" />
                            <Vertex pos="3.75 -0.5 -1.25" />
                            <Vertex pos="3.75 -0.5 -1.75" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 64 -0.375 0 -1 40 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.351123 0 0.936329 -0.146301" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.351123 0 -0.936329 -0.321863" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="622" owner="0" type="0" pos="-42.75 13 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -42.75 0 1 0 13 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0 0.25" />
                            <Vertex pos="0.25 0 -0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="0.25 -4 -0.75" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                            <Vertex pos="-0.25 -4 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 128 0 0.125 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.124035 0.992278 -0.248069" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.124035 -0.992278 -0.248069" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="623" owner="0" type="0" pos="-45.25 13 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -45.25 0 1 0 13 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0 0.25" />
                            <Vertex pos="0.25 0 -0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="0.25 -4 -0.75" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                            <Vertex pos="-0.25 -4 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0.125 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.124035 0.992278 -0.248069" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.124035 -0.992278 -0.248069" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="624" owner="0" type="0" pos="-42.75 5 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -42.75 0 1 0 5 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0 0.25" />
                            <Vertex pos="0.25 0 -0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="0.25 -4 -0.75" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                            <Vertex pos="-0.25 -4 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 128 0 0.125 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.124035 0.992278 -0.248069" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.124035 -0.992278 -0.248069" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="625" owner="0" type="0" pos="-45.25 5 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -45.25 0 1 0 5 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0 0.25" />
                            <Vertex pos="0.25 0 -0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="0.25 -4 -0.75" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                            <Vertex pos="-0.25 -4 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0.125 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.124035 0.992278 -0.248069" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.124035 -0.992278 -0.248069" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="626" owner="0" type="0" pos="-42.75 9 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -42.75 0 1 0 9 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0 0.25" />
                            <Vertex pos="0.25 0 -0.25" />
                            <Vertex pos="0.25 -4 -1.25" />
                            <Vertex pos="0.25 -4 -1.75" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -4 -1.25" />
                            <Vertex pos="-0.25 -4 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0.375 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.351123 0.936329 -0.234082" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.351123 -0.936329 -0.234082" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="627" owner="0" type="0" pos="-45.25 9 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -45.25 0 1 0 9 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0 0.25" />
                            <Vertex pos="0.25 0 -0.25" />
                            <Vertex pos="0.25 -4 -1.25" />
                            <Vertex pos="0.25 -4 -1.75" />
                            <Vertex pos="-0.25 0 0.25" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 -4 -1.25" />
                            <Vertex pos="-0.25 -4 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0.375 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.351123 0.936329 -0.234082" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.351123 -0.936329 -0.234082" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="628" owner="0" type="0" pos="-32.75 43 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -32.75 0 1 0 43 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0 -0.25" />
                            <Vertex pos="1.75 0 -0.75" />
                            <Vertex pos="1.75 -0.5 -0.25" />
                            <Vertex pos="1.75 -0.5 -0.75" />
                            <Vertex pos="-2.25 0 0.25" />
                            <Vertex pos="-2.25 0 -0.25" />
                            <Vertex pos="-2.25 -0.5 0.25" />
                            <Vertex pos="-2.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -320 -0.125 0 -1 -8 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.124035 0 0.992278 0.0310087" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.124035 0 -0.992278 -0.527148" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="629" owner="0" type="0" pos="-32.75 47.5 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -32.75 0 1 0 47.5 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0 -0.25" />
                            <Vertex pos="1.75 0 -0.75" />
                            <Vertex pos="1.75 -0.5 -0.25" />
                            <Vertex pos="1.75 -0.5 -0.75" />
                            <Vertex pos="-2.25 0 0.25" />
                            <Vertex pos="-2.25 0 -0.25" />
                            <Vertex pos="-2.25 -0.5 0.25" />
                            <Vertex pos="-2.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -448 -0.125 0 -1 -8 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.124035 0 0.992278 0.0310087" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.124035 0 -0.992278 -0.527148" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="630" owner="0" type="0" pos="-36.75 43 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -36.75 0 1 0 43 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0 0.25" />
                            <Vertex pos="1.75 0 -0.25" />
                            <Vertex pos="1.75 -0.5 0.25" />
                            <Vertex pos="1.75 -0.5 -0.25" />
                            <Vertex pos="-2.25 0 0.25" />
                            <Vertex pos="-2.25 0 -0.25" />
                            <Vertex pos="-2.25 -0.5 0.25" />
                            <Vertex pos="-2.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="631" owner="0" type="0" pos="-36.75 47.5 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -36.75 0 1 0 47.5 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0 0.25" />
                            <Vertex pos="1.75 0 -0.25" />
                            <Vertex pos="1.75 -0.5 0.25" />
                            <Vertex pos="1.75 -0.5 -0.25" />
                            <Vertex pos="-2.25 0 0.25" />
                            <Vertex pos="-2.25 0 -0.25" />
                            <Vertex pos="-2.25 -0.5 0.25" />
                            <Vertex pos="-2.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="632" owner="0" type="0" pos="-40.75 43 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -40.75 0 1 0 43 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0 0.25" />
                            <Vertex pos="1.75 0 -0.25" />
                            <Vertex pos="1.75 -0.5 0.25" />
                            <Vertex pos="1.75 -0.5 -0.25" />
                            <Vertex pos="-2.25 0 -0.25" />
                            <Vertex pos="-2.25 0 -0.75" />
                            <Vertex pos="-2.25 -0.5 -0.25" />
                            <Vertex pos="-2.25 -0.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -320 0.125 0 -1 8 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.124035 0 0.992278 -0.0310087" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.124035 0 -0.992278 -0.46513" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="633" owner="0" type="0" pos="-40.75 47.5 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -40.75 0 1 0 47.5 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0 0.25" />
                            <Vertex pos="1.75 0 -0.25" />
                            <Vertex pos="1.75 -0.5 0.25" />
                            <Vertex pos="1.75 -0.5 -0.25" />
                            <Vertex pos="-2.25 0 -0.25" />
                            <Vertex pos="-2.25 0 -0.75" />
                            <Vertex pos="-2.25 -0.5 -0.25" />
                            <Vertex pos="-2.25 -0.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -448 0.125 0 -1 8 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.124035 0 0.992278 -0.0310087" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.124035 0 -0.992278 -0.46513" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="634" owner="0" type="0" pos="-44.75 43 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -44.75 0 1 0 43 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0 0.25" />
                            <Vertex pos="1.75 0 -0.25" />
                            <Vertex pos="1.75 -0.5 0.25" />
                            <Vertex pos="1.75 -0.5 -0.25" />
                            <Vertex pos="-6.25 0 -1.75" />
                            <Vertex pos="-6.25 0 -2.25" />
                            <Vertex pos="-6.25 -0.5 -1.75" />
                            <Vertex pos="-6.25 -0.5 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -4928 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -320 0.25 0 -1 -48 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 0.181902" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.666973" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="635" owner="0" type="0" pos="-44.75 47.5 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -44.75 0 1 0 47.5 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0 0.25" />
                            <Vertex pos="1.75 0 -0.25" />
                            <Vertex pos="1.75 -0.5 0.25" />
                            <Vertex pos="1.75 -0.5 -0.25" />
                            <Vertex pos="-6.25 0 -1.75" />
                            <Vertex pos="-6.25 0 -2.25" />
                            <Vertex pos="-6.25 -0.5 -1.75" />
                            <Vertex pos="-6.25 -0.5 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -1472 0.25 0 -1 -48 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 5056 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 0.181902" album="" material="bm_edge_white" texgens="1 0 0 5056 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.666973" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="636" owner="0" type="0" pos="-105 37 27" rot="1 0 0 0" scale="" transform="1 0 0 -105 0 1 0 37 0 0 1 27 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 -20 -6" />
                            <Vertex pos="0 -20 -10" />
                            <Vertex pos="0 -24 -6" />
                            <Vertex pos="0 -24 -10" />
                            <Vertex pos="-2 -20 -6" />
                            <Vertex pos="-2 -20 -10" />
                            <Vertex pos="-2 -24 -6" />
                            <Vertex pos="-2 -24 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -24" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="637" owner="0" type="0" pos="-13 -5 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -5 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 26 0.25" />
                            <Vertex pos="6 26 -0.25" />
                            <Vertex pos="6 -6 0.25" />
                            <Vertex pos="6 -6 -0.25" />
                            <Vertex pos="-18 26 0.25" />
                            <Vertex pos="-18 26 -0.25" />
                            <Vertex pos="-18 -6 0.25" />
                            <Vertex pos="-18 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -18" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -26" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="638" owner="0" type="0" pos="-13 27 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 27 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 26 0.25" />
                            <Vertex pos="4 26 -0.25" />
                            <Vertex pos="4 -6 0.25" />
                            <Vertex pos="4 -6 -0.25" />
                            <Vertex pos="-18 26 0.25" />
                            <Vertex pos="-18 26 -0.25" />
                            <Vertex pos="-18 -6 0.25" />
                            <Vertex pos="-18 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -18" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -26" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="639" owner="0" type="0" pos="11 13 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 13 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 8 0.25" />
                            <Vertex pos="0 8 -0.25" />
                            <Vertex pos="0 -6 0.25" />
                            <Vertex pos="0 -6 -0.25" />
                            <Vertex pos="-18 8 0.25" />
                            <Vertex pos="-18 8 -0.25" />
                            <Vertex pos="-18 -6 0.25" />
                            <Vertex pos="-18 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -18" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="640" owner="0" type="0" pos="35 21 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 35 0 1 0 21 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 26 0.25" />
                            <Vertex pos="0 26 -0.25" />
                            <Vertex pos="0 -6 0.25" />
                            <Vertex pos="0 -6 -0.25" />
                            <Vertex pos="-22 26 0.25" />
                            <Vertex pos="-22 26 -0.25" />
                            <Vertex pos="-22 -6 0.25" />
                            <Vertex pos="-22 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -22" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -26" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="641" owner="0" type="0" pos="13 13 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 13 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 8 0.25" />
                            <Vertex pos="0 8 -0.25" />
                            <Vertex pos="0 2 0.25" />
                            <Vertex pos="0 2 -0.25" />
                            <Vertex pos="-2 8 0.25" />
                            <Vertex pos="-2 8 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="642" owner="0" type="0" pos="13 35 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 35 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 28 0.25" />
                            <Vertex pos="0 28 -0.25" />
                            <Vertex pos="0 -6 0.25" />
                            <Vertex pos="0 -6 -0.25" />
                            <Vertex pos="-22 28 0.25" />
                            <Vertex pos="-22 28 -0.25" />
                            <Vertex pos="-22 -6 0.25" />
                            <Vertex pos="-22 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -22" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -28" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="643" owner="0" type="0" pos="-13 37 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 37 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 26 0.25" />
                            <Vertex pos="4 26 -0.25" />
                            <Vertex pos="4 22 0.25" />
                            <Vertex pos="4 22 -0.25" />
                            <Vertex pos="-18 26 0.25" />
                            <Vertex pos="-18 26 -0.25" />
                            <Vertex pos="-18 22 0.25" />
                            <Vertex pos="-18 22 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -18" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -26" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 22" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="644" owner="0" type="0" pos="-13 33 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 33 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 26 0.25" />
                            <Vertex pos="4 26 -0.25" />
                            <Vertex pos="4 20 0.25" />
                            <Vertex pos="4 20 -0.25" />
                            <Vertex pos="-6 26 0.25" />
                            <Vertex pos="-6 26 -0.25" />
                            <Vertex pos="-6 20 0.25" />
                            <Vertex pos="-6 20 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -26" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 20" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="645" owner="0" type="0" pos="-29 33 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 33 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 26 0.25" />
                            <Vertex pos="4 26 -0.25" />
                            <Vertex pos="4 20 0.25" />
                            <Vertex pos="4 20 -0.25" />
                            <Vertex pos="-2 26 0.25" />
                            <Vertex pos="-2 26 -0.25" />
                            <Vertex pos="-2 20 0.25" />
                            <Vertex pos="-2 20 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -26" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 20" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="646" owner="0" type="0" pos="13 77 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 77 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 10 0.25" />
                            <Vertex pos="0 10 -0.25" />
                            <Vertex pos="0 -6 0.25" />
                            <Vertex pos="0 -6 -0.25" />
                            <Vertex pos="-10 10 0.25" />
                            <Vertex pos="-10 10 -0.25" />
                            <Vertex pos="-10 -6 0.25" />
                            <Vertex pos="-10 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="647" owner="0" type="0" pos="-3 77 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 77 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 10 0.25" />
                            <Vertex pos="0 10 -0.25" />
                            <Vertex pos="0 -6 0.25" />
                            <Vertex pos="0 -6 -0.25" />
                            <Vertex pos="-36 10 0.25" />
                            <Vertex pos="-36 10 -0.25" />
                            <Vertex pos="-36 -6 0.25" />
                            <Vertex pos="-36 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -36" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="649" owner="0" type="0" pos="11 81 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 81 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 10 0.25" />
                            <Vertex pos="0 10 -0.25" />
                            <Vertex pos="0 6 0.25" />
                            <Vertex pos="0 6 -0.25" />
                            <Vertex pos="-20 10 0.25" />
                            <Vertex pos="-20 10 -0.25" />
                            <Vertex pos="-20 6 0.25" />
                            <Vertex pos="-20 6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -20" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 6" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="652" owner="0" type="0" pos="7 77 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 77 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 10 0.25" />
                            <Vertex pos="-4 10 -0.25" />
                            <Vertex pos="-4 4 0.25" />
                            <Vertex pos="-4 4 -0.25" />
                            <Vertex pos="-10 10 0.25" />
                            <Vertex pos="-10 10 -0.25" />
                            <Vertex pos="-10 4 0.25" />
                            <Vertex pos="-10 4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 4" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="653" owner="0" type="0" pos="-39 77 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 77 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 10 0.25" />
                            <Vertex pos="0 10 -0.25" />
                            <Vertex pos="0 -18 0.25" />
                            <Vertex pos="0 -18 -0.25" />
                            <Vertex pos="-24 10 0.25" />
                            <Vertex pos="-24 10 -0.25" />
                            <Vertex pos="-24 -18 0.25" />
                            <Vertex pos="-24 -18 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -24" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -18" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="654" owner="0" type="0" pos="-39 29 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 29 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 10 0.25" />
                            <Vertex pos="0 10 -0.25" />
                            <Vertex pos="0 -20 0.25" />
                            <Vertex pos="0 -20 -0.25" />
                            <Vertex pos="-58 10 0.25" />
                            <Vertex pos="-58 10 -0.25" />
                            <Vertex pos="-58 -20 0.25" />
                            <Vertex pos="-58 -20 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -58" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -20" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="655" owner="0" type="0" pos="-39 49 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 49 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 10 0.25" />
                            <Vertex pos="0 10 -0.25" />
                            <Vertex pos="0 -10 0.25" />
                            <Vertex pos="0 -10 -0.25" />
                            <Vertex pos="-12 10 0.25" />
                            <Vertex pos="-12 10 -0.25" />
                            <Vertex pos="-12 -10 0.25" />
                            <Vertex pos="-12 -10 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="656" owner="0" type="0" pos="-57 55 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -57 0 1 0 55 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 4 0.25" />
                            <Vertex pos="0 4 -0.25" />
                            <Vertex pos="0 -10 0.25" />
                            <Vertex pos="0 -10 -0.25" />
                            <Vertex pos="-6 4 0.25" />
                            <Vertex pos="-6 4 -0.25" />
                            <Vertex pos="-6 -10 0.25" />
                            <Vertex pos="-6 -10 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="657" owner="0" type="0" pos="-63 45 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -63 0 1 0 45 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 4 0.25" />
                            <Vertex pos="0 4 -0.25" />
                            <Vertex pos="0 0 0.25" />
                            <Vertex pos="0 0 -0.25" />
                            <Vertex pos="-44 4 0.25" />
                            <Vertex pos="-44 4 -0.25" />
                            <Vertex pos="-44 0 0.25" />
                            <Vertex pos="-44 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -44" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="658" owner="0" type="0" pos="-63 41 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -63 0 1 0 41 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 4 0.25" />
                            <Vertex pos="-4 4 -0.25" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-4 -2 -0.25" />
                            <Vertex pos="-44 4 0.25" />
                            <Vertex pos="-44 4 -0.25" />
                            <Vertex pos="-44 -2 0.25" />
                            <Vertex pos="-44 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -44" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="659" owner="0" type="0" pos="-63 35 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -63 0 1 0 35 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-34 4 0.25" />
                            <Vertex pos="-34 4 -0.25" />
                            <Vertex pos="-34 -14 0.25" />
                            <Vertex pos="-34 -14 -0.25" />
                            <Vertex pos="-44 4 0.25" />
                            <Vertex pos="-44 4 -0.25" />
                            <Vertex pos="-44 -14 0.25" />
                            <Vertex pos="-44 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 34" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -44" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="660" owner="0" type="0" pos="-57 3 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -57 0 1 0 3 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 -2 0.25" />
                            <Vertex pos="-8 -2 -0.25" />
                            <Vertex pos="-8 -14 0.25" />
                            <Vertex pos="-8 -14 -0.25" />
                            <Vertex pos="-44 -2 0.25" />
                            <Vertex pos="-44 -2 -0.25" />
                            <Vertex pos="-44 -14 0.25" />
                            <Vertex pos="-44 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -44" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 2" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="661" owner="0" type="0" pos="-23 3 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 3 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 -2 0.25" />
                            <Vertex pos="-8 -2 -0.25" />
                            <Vertex pos="-8 -14 0.25" />
                            <Vertex pos="-8 -14 -0.25" />
                            <Vertex pos="-24 -2 0.25" />
                            <Vertex pos="-24 -2 -0.25" />
                            <Vertex pos="-24 -14 0.25" />
                            <Vertex pos="-24 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -24" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 2" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="662" owner="0" type="0" pos="-39 9 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 9 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 -8 0.25" />
                            <Vertex pos="-8 -8 -0.25" />
                            <Vertex pos="-8 -14 0.25" />
                            <Vertex pos="-8 -14 -0.25" />
                            <Vertex pos="-26 -8 0.25" />
                            <Vertex pos="-26 -8 -0.25" />
                            <Vertex pos="-26 -14 0.25" />
                            <Vertex pos="-26 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -26" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 8" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="663" owner="0" type="0" pos="-47 -17 -1" rot="1 0 0 0" scale="" transform="1 0 0 -47 0 1 0 -17 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0" />
                            <Vertex pos="2 6 -2" />
                            <Vertex pos="2 -8 0" />
                            <Vertex pos="2 -8 -2" />
                            <Vertex pos="-10 6 0" />
                            <Vertex pos="-10 6 -2" />
                            <Vertex pos="-10 -8 0" />
                            <Vertex pos="-10 -8 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 -1536 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank1" texgens="0 -1 0 1792 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank1" texgens="-1 0 0 256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 256 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="664" owner="0" type="0" pos="-75 -17 -1" rot="1 0 0 0" scale="" transform="1 0 0 -75 0 1 0 -17 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0" />
                            <Vertex pos="2 6 -2" />
                            <Vertex pos="2 -8 0" />
                            <Vertex pos="2 -8 -2" />
                            <Vertex pos="-10 6 0" />
                            <Vertex pos="-10 6 -2" />
                            <Vertex pos="-10 -8 0" />
                            <Vertex pos="-10 -8 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 -1536 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank1" texgens="0 -1 0 1792 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank1" texgens="-1 0 0 256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 256 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="665" owner="0" type="0" pos="-23 -1 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 -1 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 -10 0.25" />
                            <Vertex pos="-8 -10 -0.25" />
                            <Vertex pos="-8 -14 0.25" />
                            <Vertex pos="-8 -14 -0.25" />
                            <Vertex pos="-22 -10 0.25" />
                            <Vertex pos="-22 -10 -0.25" />
                            <Vertex pos="-22 -14 0.25" />
                            <Vertex pos="-22 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -22" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 10" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="666" owner="0" type="0" pos="-49 -1 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -49 0 1 0 -1 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 -10 0.25" />
                            <Vertex pos="-8 -10 -0.25" />
                            <Vertex pos="-8 -14 0.25" />
                            <Vertex pos="-8 -14 -0.25" />
                            <Vertex pos="-24 -10 0.25" />
                            <Vertex pos="-24 -10 -0.25" />
                            <Vertex pos="-24 -14 0.25" />
                            <Vertex pos="-24 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -24" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 10" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="667" owner="0" type="0" pos="-77 -1 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -77 0 1 0 -1 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 -10 0.25" />
                            <Vertex pos="-8 -10 -0.25" />
                            <Vertex pos="-8 -14 0.25" />
                            <Vertex pos="-8 -14 -0.25" />
                            <Vertex pos="-22 -10 0.25" />
                            <Vertex pos="-22 -10 -0.25" />
                            <Vertex pos="-22 -14 0.25" />
                            <Vertex pos="-22 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -22" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 10" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="668" owner="0" type="0" pos="-23 -11 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 -11 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 -8 0.25" />
                            <Vertex pos="-8 -8 -0.25" />
                            <Vertex pos="-8 -14 0.25" />
                            <Vertex pos="-8 -14 -0.25" />
                            <Vertex pos="-22 -8 0.25" />
                            <Vertex pos="-22 -8 -0.25" />
                            <Vertex pos="-22 -14 0.25" />
                            <Vertex pos="-22 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -22" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 8" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="669" owner="0" type="0" pos="-49 -11 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -49 0 1 0 -11 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 -8 0.25" />
                            <Vertex pos="-8 -8 -0.25" />
                            <Vertex pos="-8 -14 0.25" />
                            <Vertex pos="-8 -14 -0.25" />
                            <Vertex pos="-24 -8 0.25" />
                            <Vertex pos="-24 -8 -0.25" />
                            <Vertex pos="-24 -14 0.25" />
                            <Vertex pos="-24 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -24" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 8" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="670" owner="0" type="0" pos="-77 -11 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -77 0 1 0 -11 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 -8 0.25" />
                            <Vertex pos="-8 -8 -0.25" />
                            <Vertex pos="-8 -14 0.25" />
                            <Vertex pos="-8 -14 -0.25" />
                            <Vertex pos="-22 -8 0.25" />
                            <Vertex pos="-22 -8 -0.25" />
                            <Vertex pos="-22 -14 0.25" />
                            <Vertex pos="-22 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -22" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 8" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="671" owner="0" type="0" pos="11 91 -5.25" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 91 0 0 1 -5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 10 0.25" />
                            <Vertex pos="0 10 -0.25" />
                            <Vertex pos="0 4 0.25" />
                            <Vertex pos="0 4 -0.25" />
                            <Vertex pos="-20 10 0.25" />
                            <Vertex pos="-20 10 -0.25" />
                            <Vertex pos="-20 4 0.25" />
                            <Vertex pos="-20 4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -20" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 4" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="672" owner="0" type="0" pos="-27 5 19" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 5 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -20 -6" />
                            <Vertex pos="1.5 -20 -10" />
                            <Vertex pos="1.5 -28 -6" />
                            <Vertex pos="1.5 -28 -10" />
                            <Vertex pos="-1.5 -20 -6" />
                            <Vertex pos="-1.5 -20 -10" />
                            <Vertex pos="-1.5 -28 -6" />
                            <Vertex pos="-1.5 -28 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -28" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="673" owner="0" type="0" pos="-27 1 19" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 1 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -24 -8" />
                            <Vertex pos="1.5 -24 -10" />
                            <Vertex pos="1.5 -28 -8" />
                            <Vertex pos="1.5 -28 -10" />
                            <Vertex pos="-1.5 -24 -8" />
                            <Vertex pos="-1.5 -24 -10" />
                            <Vertex pos="-1.5 -28 -8" />
                            <Vertex pos="-1.5 -28 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 24" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -28" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="674" owner="0" type="0" pos="-23 9 19" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 9 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 -20.5 -4" />
                            <Vertex pos="8 -20.5 -10" />
                            <Vertex pos="8 -23.5 -4" />
                            <Vertex pos="8 -23.5 -10" />
                            <Vertex pos="-2 -20.5 -4" />
                            <Vertex pos="-2 -20.5 -10" />
                            <Vertex pos="-2 -23.5 -4" />
                            <Vertex pos="-2 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="675" owner="0" type="0" pos="1 9 19" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 9 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 -20.5 -4" />
                            <Vertex pos="10 -20.5 -10" />
                            <Vertex pos="10 -23.5 -4" />
                            <Vertex pos="10 -23.5 -10" />
                            <Vertex pos="0 -20.5 -4" />
                            <Vertex pos="0 -20.5 -10" />
                            <Vertex pos="0 -23.5 -4" />
                            <Vertex pos="0 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="676" owner="0" type="0" pos="-11 9 19" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 9 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -20.5 -2" />
                            <Vertex pos="12 -20.5 -10" />
                            <Vertex pos="12 -23.5 -2" />
                            <Vertex pos="12 -23.5 -10" />
                            <Vertex pos="-4 -20.5 -2" />
                            <Vertex pos="-4 -20.5 -10" />
                            <Vertex pos="-4 -23.5 -2" />
                            <Vertex pos="-4 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="677" owner="0" type="0" pos="13 17 19" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 17 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -14 -6" />
                            <Vertex pos="1.5 -14 -10" />
                            <Vertex pos="1.5 -28 -6" />
                            <Vertex pos="1.5 -28 -10" />
                            <Vertex pos="-1.5 -14 -6" />
                            <Vertex pos="-1.5 -14 -10" />
                            <Vertex pos="-1.5 -28 -6" />
                            <Vertex pos="-1.5 -28 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 14" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -28" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="678" owner="0" type="0" pos="13 25 19" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 25 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -14 -8" />
                            <Vertex pos="1.5 -14 -10" />
                            <Vertex pos="1.5 -22 -8" />
                            <Vertex pos="1.5 -22 -10" />
                            <Vertex pos="-1.5 -14 -8" />
                            <Vertex pos="-1.5 -14 -10" />
                            <Vertex pos="-1.5 -22 -8" />
                            <Vertex pos="-1.5 -22 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 14" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -22" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="679" owner="0" type="0" pos="17 35 19" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 35 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 -20.5 -8" />
                            <Vertex pos="6 -20.5 -10" />
                            <Vertex pos="6 -23.5 -8" />
                            <Vertex pos="6 -23.5 -10" />
                            <Vertex pos="-2 -20.5 -8" />
                            <Vertex pos="-2 -20.5 -10" />
                            <Vertex pos="-2 -23.5 -8" />
                            <Vertex pos="-2 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="680" owner="0" type="0" pos="29 35 19" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 35 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 -20.5 -2" />
                            <Vertex pos="6 -20.5 -10" />
                            <Vertex pos="6 -23.5 -2" />
                            <Vertex pos="6 -23.5 -10" />
                            <Vertex pos="-2 -20.5 -2" />
                            <Vertex pos="-2 -20.5 -10" />
                            <Vertex pos="-2 -23.5 -2" />
                            <Vertex pos="-2 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="681" owner="0" type="0" pos="25 35 19" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 35 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -20.5 -4" />
                            <Vertex pos="2 -20.5 -10" />
                            <Vertex pos="2 -23.5 -4" />
                            <Vertex pos="2 -23.5 -10" />
                            <Vertex pos="-2 -20.5 -4" />
                            <Vertex pos="-2 -20.5 -10" />
                            <Vertex pos="-2 -23.5 -4" />
                            <Vertex pos="-2 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="682" owner="0" type="0" pos="37 43 19" rot="1 0 0 0" scale="" transform="1 0 0 37 0 1 0 43 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -20 -2" />
                            <Vertex pos="1.5 -20 -10" />
                            <Vertex pos="1.5 -28 -2" />
                            <Vertex pos="1.5 -28 -10" />
                            <Vertex pos="-1.5 -20 -2" />
                            <Vertex pos="-1.5 -20 -10" />
                            <Vertex pos="-1.5 -28 -2" />
                            <Vertex pos="-1.5 -28 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -28" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="683" owner="0" type="0" pos="37 67 19" rot="1 0 0 0" scale="" transform="1 0 0 37 0 1 0 67 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -20 -6" />
                            <Vertex pos="1.5 -20 -10" />
                            <Vertex pos="1.5 -32 -6" />
                            <Vertex pos="1.5 -32 -10" />
                            <Vertex pos="-1.5 -20 -6" />
                            <Vertex pos="-1.5 -20 -10" />
                            <Vertex pos="-1.5 -32 -6" />
                            <Vertex pos="-1.5 -32 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -32" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="684" owner="0" type="0" pos="37 55 19" rot="1 0 0 0" scale="" transform="1 0 0 37 0 1 0 55 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -20 -8" />
                            <Vertex pos="1.5 -20 -10" />
                            <Vertex pos="1.5 -28 -8" />
                            <Vertex pos="1.5 -28 -10" />
                            <Vertex pos="-1.5 -20 -8" />
                            <Vertex pos="-1.5 -20 -10" />
                            <Vertex pos="-1.5 -28 -8" />
                            <Vertex pos="-1.5 -28 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -28" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="685" owner="0" type="0" pos="19 71 19" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 71 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 -20.5 -8" />
                            <Vertex pos="6 -20.5 -10" />
                            <Vertex pos="6 -23.5 -8" />
                            <Vertex pos="6 -23.5 -10" />
                            <Vertex pos="-2 -20.5 -8" />
                            <Vertex pos="-2 -20.5 -10" />
                            <Vertex pos="-2 -23.5 -8" />
                            <Vertex pos="-2 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="686" owner="0" type="0" pos="29 71 19" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 71 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 -20.5 -6" />
                            <Vertex pos="6 -20.5 -10" />
                            <Vertex pos="6 -23.5 -6" />
                            <Vertex pos="6 -23.5 -10" />
                            <Vertex pos="-4 -20.5 -6" />
                            <Vertex pos="-4 -20.5 -10" />
                            <Vertex pos="-4 -23.5 -6" />
                            <Vertex pos="-4 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="687" owner="0" type="0" pos="15 73 19" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 73 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -10 -8" />
                            <Vertex pos="1.5 -10 -10" />
                            <Vertex pos="1.5 -22 -8" />
                            <Vertex pos="1.5 -22 -10" />
                            <Vertex pos="-1.5 -10 -8" />
                            <Vertex pos="-1.5 -10 -10" />
                            <Vertex pos="-1.5 -22 -8" />
                            <Vertex pos="-1.5 -22 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -22" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="688" owner="0" type="0" pos="15 85 19" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 85 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 6 -6" />
                            <Vertex pos="1.5 6 -10" />
                            <Vertex pos="1.5 -22 -6" />
                            <Vertex pos="1.5 -22 -10" />
                            <Vertex pos="-1.5 6 -6" />
                            <Vertex pos="-1.5 6 -10" />
                            <Vertex pos="-1.5 -22 -6" />
                            <Vertex pos="-1.5 -22 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -22" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="689" owner="0" type="0" pos="15 109 19" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 109 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -6 -2" />
                            <Vertex pos="1.5 -6 -10" />
                            <Vertex pos="1.5 -18 -2" />
                            <Vertex pos="1.5 -18 -10" />
                            <Vertex pos="-1.5 -6 -2" />
                            <Vertex pos="-1.5 -6 -10" />
                            <Vertex pos="-1.5 -18 -2" />
                            <Vertex pos="-1.5 -18 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 6" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -18" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="690" owner="0" type="0" pos="7 127 19" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 127 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 -20.5 -2" />
                            <Vertex pos="6 -20.5 -10" />
                            <Vertex pos="6 -23.5 -2" />
                            <Vertex pos="6 -23.5 -10" />
                            <Vertex pos="-4 -20.5 -2" />
                            <Vertex pos="-4 -20.5 -10" />
                            <Vertex pos="-4 -23.5 -2" />
                            <Vertex pos="-4 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="691" owner="0" type="0" pos="-3 127 19" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 127 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 -20.5 -4" />
                            <Vertex pos="6 -20.5 -10" />
                            <Vertex pos="6 -23.5 -4" />
                            <Vertex pos="6 -23.5 -10" />
                            <Vertex pos="2 -20.5 -4" />
                            <Vertex pos="2 -20.5 -10" />
                            <Vertex pos="2 -23.5 -4" />
                            <Vertex pos="2 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="692" owner="0" type="0" pos="-7 127 19" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 127 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 -20.5 -8" />
                            <Vertex pos="6 -20.5 -10" />
                            <Vertex pos="6 -23.5 -8" />
                            <Vertex pos="6 -23.5 -10" />
                            <Vertex pos="-4 -20.5 -8" />
                            <Vertex pos="-4 -20.5 -10" />
                            <Vertex pos="-4 -23.5 -8" />
                            <Vertex pos="-4 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="693" owner="0" type="0" pos="-13 127 19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 127 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -24 -8" />
                            <Vertex pos="1.5 -24 -10" />
                            <Vertex pos="1.5 -28 -8" />
                            <Vertex pos="1.5 -28 -10" />
                            <Vertex pos="-1.5 -24 -8" />
                            <Vertex pos="-1.5 -24 -10" />
                            <Vertex pos="-1.5 -28 -8" />
                            <Vertex pos="-1.5 -28 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 24" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -28" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="694" owner="0" type="0" pos="-13 123 19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 123 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -24 -6" />
                            <Vertex pos="1.5 -24 -10" />
                            <Vertex pos="1.5 -32 -6" />
                            <Vertex pos="1.5 -32 -10" />
                            <Vertex pos="-1.5 -24 -6" />
                            <Vertex pos="-1.5 -24 -10" />
                            <Vertex pos="-1.5 -32 -6" />
                            <Vertex pos="-1.5 -32 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 24" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -32" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="695" owner="0" type="0" pos="-49 111 19" rot="1 0 0 0" scale="" transform="1 0 0 -49 0 1 0 111 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -20.5 -4" />
                            <Vertex pos="4 -20.5 -10" />
                            <Vertex pos="4 -23.5 -4" />
                            <Vertex pos="4 -23.5 -10" />
                            <Vertex pos="-2 -20.5 -4" />
                            <Vertex pos="-2 -20.5 -10" />
                            <Vertex pos="-2 -23.5 -4" />
                            <Vertex pos="-2 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="696" owner="0" type="0" pos="-21 111 19" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 111 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 -20.5 -6" />
                            <Vertex pos="6 -20.5 -10" />
                            <Vertex pos="6 -23.5 -6" />
                            <Vertex pos="6 -23.5 -10" />
                            <Vertex pos="-24 -20.5 -6" />
                            <Vertex pos="-24 -20.5 -10" />
                            <Vertex pos="-24 -23.5 -6" />
                            <Vertex pos="-24 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -24" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="697" owner="0" type="0" pos="-59 111 19" rot="1 0 0 0" scale="" transform="1 0 0 -59 0 1 0 111 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 -20.5 -2" />
                            <Vertex pos="8 -20.5 -10" />
                            <Vertex pos="8 -23.5 -2" />
                            <Vertex pos="8 -23.5 -10" />
                            <Vertex pos="-4 -20.5 -2" />
                            <Vertex pos="-4 -20.5 -10" />
                            <Vertex pos="-4 -23.5 -2" />
                            <Vertex pos="-4 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="698" owner="0" type="0" pos="-65 93 19" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 93 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -6 -2" />
                            <Vertex pos="1.5 -6 -10" />
                            <Vertex pos="1.5 -16 -2" />
                            <Vertex pos="1.5 -16 -10" />
                            <Vertex pos="-1.5 -6 -2" />
                            <Vertex pos="-1.5 -6 -10" />
                            <Vertex pos="-1.5 -16 -2" />
                            <Vertex pos="-1.5 -16 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 6" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="699" owner="0" type="0" pos="-65 67 19" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 67 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -4 -2" />
                            <Vertex pos="1.5 -4 -10" />
                            <Vertex pos="1.5 -14 -2" />
                            <Vertex pos="1.5 -14 -10" />
                            <Vertex pos="-1.5 -4 -2" />
                            <Vertex pos="-1.5 -4 -10" />
                            <Vertex pos="-1.5 -14 -2" />
                            <Vertex pos="-1.5 -14 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 4" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="700" owner="0" type="0" pos="-65 75 19" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 75 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 2 -4" />
                            <Vertex pos="1.5 2 -10" />
                            <Vertex pos="1.5 -12 -4" />
                            <Vertex pos="1.5 -12 -10" />
                            <Vertex pos="-1.5 2 -4" />
                            <Vertex pos="-1.5 2 -10" />
                            <Vertex pos="-1.5 -12 -4" />
                            <Vertex pos="-1.5 -12 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="701" owner="0" type="0" pos="-75 73 19" rot="1 0 0 0" scale="" transform="1 0 0 -75 0 1 0 73 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 -20.5 -2" />
                            <Vertex pos="8 -20.5 -10" />
                            <Vertex pos="8 -23.5 -2" />
                            <Vertex pos="8 -23.5 -10" />
                            <Vertex pos="-2 -20.5 -2" />
                            <Vertex pos="-2 -20.5 -10" />
                            <Vertex pos="-2 -23.5 -2" />
                            <Vertex pos="-2 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="702" owner="0" type="0" pos="-85 73 19" rot="1 0 0 0" scale="" transform="1 0 0 -85 0 1 0 73 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 -20.5 -4" />
                            <Vertex pos="8 -20.5 -10" />
                            <Vertex pos="8 -23.5 -4" />
                            <Vertex pos="8 -23.5 -10" />
                            <Vertex pos="4 -20.5 -4" />
                            <Vertex pos="4 -20.5 -10" />
                            <Vertex pos="4 -23.5 -4" />
                            <Vertex pos="4 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="703" owner="0" type="0" pos="-91 73 19" rot="1 0 0 0" scale="" transform="1 0 0 -91 0 1 0 73 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 -20.5 -6" />
                            <Vertex pos="10 -20.5 -10" />
                            <Vertex pos="10 -23.5 -6" />
                            <Vertex pos="10 -23.5 -10" />
                            <Vertex pos="-16 -20.5 -6" />
                            <Vertex pos="-16 -20.5 -10" />
                            <Vertex pos="-16 -23.5 -6" />
                            <Vertex pos="-16 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -16" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="704" owner="0" type="0" pos="-109 45 19" rot="1 0 0 0" scale="" transform="1 0 0 -109 0 1 0 45 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 4 -6" />
                            <Vertex pos="1.5 4 -10" />
                            <Vertex pos="1.5 -16 -6" />
                            <Vertex pos="1.5 -16 -10" />
                            <Vertex pos="-1.5 4 -6" />
                            <Vertex pos="-1.5 4 -10" />
                            <Vertex pos="-1.5 -16 -6" />
                            <Vertex pos="-1.5 -16 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="705" owner="0" type="0" pos="-109 33 19" rot="1 0 0 0" scale="" transform="1 0 0 -109 0 1 0 33 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -4 -4" />
                            <Vertex pos="1.5 -4 -10" />
                            <Vertex pos="1.5 -10 -4" />
                            <Vertex pos="1.5 -10 -10" />
                            <Vertex pos="-1.5 -4 -4" />
                            <Vertex pos="-1.5 -4 -10" />
                            <Vertex pos="-1.5 -10 -4" />
                            <Vertex pos="-1.5 -10 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 4" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="706" owner="0" type="0" pos="-109 29 19" rot="1 0 0 0" scale="" transform="1 0 0 -109 0 1 0 29 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -6 -2" />
                            <Vertex pos="1.5 -6 -10" />
                            <Vertex pos="1.5 -12 -2" />
                            <Vertex pos="1.5 -12 -10" />
                            <Vertex pos="-1.5 -6 -2" />
                            <Vertex pos="-1.5 -6 -10" />
                            <Vertex pos="-1.5 -12 -2" />
                            <Vertex pos="-1.5 -12 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 6" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="707" owner="0" type="0" pos="-103 15 19" rot="1 0 0 0" scale="" transform="1 0 0 -103 0 1 0 15 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -2 -2" />
                            <Vertex pos="1.5 -2 -10" />
                            <Vertex pos="1.5 -22 -2" />
                            <Vertex pos="1.5 -22 -10" />
                            <Vertex pos="-1.5 -2 -2" />
                            <Vertex pos="-1.5 -2 -10" />
                            <Vertex pos="-1.5 -22 -2" />
                            <Vertex pos="-1.5 -22 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 2" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -22" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="708" owner="0" type="0" pos="-103 -5 19" rot="1 0 0 0" scale="" transform="1 0 0 -103 0 1 0 -5 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -2 -6" />
                            <Vertex pos="1.5 -2 -10" />
                            <Vertex pos="1.5 -14 -6" />
                            <Vertex pos="1.5 -14 -10" />
                            <Vertex pos="-1.5 -2 -6" />
                            <Vertex pos="-1.5 -2 -10" />
                            <Vertex pos="-1.5 -14 -6" />
                            <Vertex pos="-1.5 -14 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 2" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="709" owner="0" type="0" pos="-103 -17 19" rot="1 0 0 0" scale="" transform="1 0 0 -103 0 1 0 -17 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -2 -8" />
                            <Vertex pos="1.5 -2 -10" />
                            <Vertex pos="1.5 -10 -8" />
                            <Vertex pos="1.5 -10 -10" />
                            <Vertex pos="-1.5 -2 -8" />
                            <Vertex pos="-1.5 -2 -10" />
                            <Vertex pos="-1.5 -10 -8" />
                            <Vertex pos="-1.5 -10 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 2" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="710" owner="0" type="0" pos="-85 -7 19" rot="1 0 0 0" scale="" transform="1 0 0 -85 0 1 0 -7 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 -20.5 -8" />
                            <Vertex pos="-8 -20.5 -10" />
                            <Vertex pos="-8 -23.5 -8" />
                            <Vertex pos="-8 -23.5 -10" />
                            <Vertex pos="-16 -20.5 -8" />
                            <Vertex pos="-16 -20.5 -10" />
                            <Vertex pos="-16 -23.5 -8" />
                            <Vertex pos="-16 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -16" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="711" owner="0" type="0" pos="-77 -7 19" rot="1 0 0 0" scale="" transform="1 0 0 -77 0 1 0 -7 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -20.5 -6" />
                            <Vertex pos="4 -20.5 -10" />
                            <Vertex pos="4 -23.5 -6" />
                            <Vertex pos="4 -23.5 -10" />
                            <Vertex pos="-16 -20.5 -6" />
                            <Vertex pos="-16 -20.5 -10" />
                            <Vertex pos="-16 -23.5 -6" />
                            <Vertex pos="-16 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -16" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="712" owner="0" type="0" pos="-57 -7 19" rot="1 0 0 0" scale="" transform="1 0 0 -57 0 1 0 -7 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 -20.5 -8" />
                            <Vertex pos="-8 -20.5 -10" />
                            <Vertex pos="-8 -23.5 -8" />
                            <Vertex pos="-8 -23.5 -10" />
                            <Vertex pos="-16 -20.5 -8" />
                            <Vertex pos="-16 -20.5 -10" />
                            <Vertex pos="-16 -23.5 -8" />
                            <Vertex pos="-16 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -16" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="713" owner="0" type="0" pos="-33 -7 19" rot="1 0 0 0" scale="" transform="1 0 0 -33 0 1 0 -7 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -20.5 -8" />
                            <Vertex pos="4 -20.5 -10" />
                            <Vertex pos="4 -23.5 -8" />
                            <Vertex pos="4 -23.5 -10" />
                            <Vertex pos="-4 -20.5 -8" />
                            <Vertex pos="-4 -20.5 -10" />
                            <Vertex pos="-4 -23.5 -8" />
                            <Vertex pos="-4 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="714" owner="0" type="0" pos="-47 -7 19" rot="1 0 0 0" scale="" transform="1 0 0 -47 0 1 0 -7 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -20.5 -2" />
                            <Vertex pos="4 -20.5 -10" />
                            <Vertex pos="4 -23.5 -2" />
                            <Vertex pos="4 -23.5 -10" />
                            <Vertex pos="-10 -20.5 -2" />
                            <Vertex pos="-10 -20.5 -10" />
                            <Vertex pos="-10 -23.5 -2" />
                            <Vertex pos="-10 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="715" owner="0" type="0" pos="-57 -7 19" rot="1 0 0 0" scale="" transform="1 0 0 -57 0 1 0 -7 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 -20.5 -6" />
                            <Vertex pos="-2 -20.5 -10" />
                            <Vertex pos="-2 -23.5 -6" />
                            <Vertex pos="-2 -23.5 -10" />
                            <Vertex pos="-8 -20.5 -6" />
                            <Vertex pos="-8 -20.5 -10" />
                            <Vertex pos="-8 -23.5 -6" />
                            <Vertex pos="-8 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="716" owner="0" type="0" pos="-35 -7 19" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 -7 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -20.5 -4" />
                            <Vertex pos="-6 -20.5 -10" />
                            <Vertex pos="-6 -23.5 -4" />
                            <Vertex pos="-6 -23.5 -10" />
                            <Vertex pos="-8 -20.5 -4" />
                            <Vertex pos="-8 -20.5 -10" />
                            <Vertex pos="-8 -23.5 -4" />
                            <Vertex pos="-8 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 6" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="717" owner="0" type="0" pos="37 51 19" rot="1 0 0 0" scale="" transform="1 0 0 37 0 1 0 51 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -26 -4" />
                            <Vertex pos="1.5 -26 -10" />
                            <Vertex pos="1.5 -28 -4" />
                            <Vertex pos="1.5 -28 -10" />
                            <Vertex pos="-1.5 -26 -4" />
                            <Vertex pos="-1.5 -26 -10" />
                            <Vertex pos="-1.5 -28 -4" />
                            <Vertex pos="-1.5 -28 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 26" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -28" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="718" owner="0" type="0" pos="37 53 19" rot="1 0 0 0" scale="" transform="1 0 0 37 0 1 0 53 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -26 -6" />
                            <Vertex pos="1.5 -26 -10" />
                            <Vertex pos="1.5 -28 -6" />
                            <Vertex pos="1.5 -28 -10" />
                            <Vertex pos="-1.5 -26 -6" />
                            <Vertex pos="-1.5 -26 -10" />
                            <Vertex pos="-1.5 -28 -6" />
                            <Vertex pos="-1.5 -28 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 26" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -28" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="719" owner="0" type="0" pos="-53 -7 19" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 -7 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -20.5 -4" />
                            <Vertex pos="-4 -20.5 -10" />
                            <Vertex pos="-4 -23.5 -4" />
                            <Vertex pos="-4 -23.5 -10" />
                            <Vertex pos="-6 -20.5 -4" />
                            <Vertex pos="-6 -20.5 -10" />
                            <Vertex pos="-6 -23.5 -4" />
                            <Vertex pos="-6 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="720" owner="0" type="0" pos="-33 -7 19" rot="1 0 0 0" scale="" transform="1 0 0 -33 0 1 0 -7 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -20.5 -6" />
                            <Vertex pos="-4 -20.5 -10" />
                            <Vertex pos="-4 -23.5 -6" />
                            <Vertex pos="-4 -23.5 -10" />
                            <Vertex pos="-8 -20.5 -6" />
                            <Vertex pos="-8 -20.5 -10" />
                            <Vertex pos="-8 -23.5 -6" />
                            <Vertex pos="-8 -23.5 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 20.5" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23.5" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
